using System;
using System.Collections;
using System.Collections.Generic;
using RSG;
using UniRx;
using UnityEngine;
using UnityEngine.Assertions;
using System.IO;
using System.Runtime.InteropServices;
using Object = UnityEngine.Object;

public partial class ResourceManager
{
    abstract class WWWResource
    {
        public Object asset;

        public abstract void GenerateAsset(WWW www);
    }

    class WWWTexture : WWWResource
    {
        public override void GenerateAsset(WWW www)
        {
            Assert.IsNotNull(www);
            Assert.IsTrue(string.IsNullOrEmpty(www.error));

            asset = www.texture;
        }
    }

    class WWWAudioClip : WWWResource
    {
        public override void GenerateAsset(WWW www)
        {
            Assert.IsNotNull(www);
            Assert.IsTrue(string.IsNullOrEmpty(www.error));

            asset = www.GetAudioClip();
        }
    }

    class WWWWrapper
    {
        class RefData
        {
            public object owner;
            public List<int> internalRefList = new List<int>(DEFAULT_LIST_SIZE);
        }

        public string path;
        public WWWResource asset;

        public bool loadDone;
        public List<Action> loadDoneAction;

        private List<RefData> _referenceList = new List<RefData>(DEFAULT_LIST_SIZE);

        private RefData FindRefData(object owner)
        {
            for (int i = 0, length = _referenceList.Count; i < length; ++i)
            {
                RefData refData = _referenceList[i];

                if (refData.owner == owner)
                {
                    return refData;
                }
            }

            return null;
        }

        public void DestroyAllReference()
        {
            _referenceList.Clear();
        }

        public void DestroyReference(object owner)
        {
            RefData refData = FindRefData(owner);
            Assert.IsNotNull(refData);

            Assert.IsTrue(refData.internalRefList.Count > 0);

            refData.internalRefList.RemoveAt(0);    // remove first internal id
            if (refData.internalRefList.Count == 0)
            {
                bool removed = _referenceList.Remove(refData);
                Assert.IsTrue(removed, string.Format("remove {0} is not exist", owner));
            }
        }

        public void AddReference(object owner, int id)
        {
            RefData refData = FindRefData(owner);

            if (refData == null)
            {
                refData = new RefData { owner = owner };
                refData.internalRefList.Add(id);

                _referenceList.Add(refData);
            }
            else
            {
                Assert.IsNotNull(refData.internalRefList);
                Assert.IsFalse(refData.internalRefList.Contains(id));

                refData.internalRefList.Add(id);
            }
        }

        public bool IsAllDestroyed()
        {
            return _referenceList.Count == 0;
        }

        public bool IsContainTarget(object owner, int id)
        {
            RefData refData = FindRefData(owner);

            return refData.internalRefList.Contains(id);
        }

        public int GetReferenceCount()
        {
            int refCount = 0;
            for (int i = 0, length = _referenceList.Count; i < length; ++i)
            {
                refCount += _referenceList[i].internalRefList.Count;
            }

            return refCount;
        }
    }

    private Dictionary<string, WWWWrapper> _wwwWrappers = new Dictionary<string, WWWWrapper>();

    public int GetWWWWrappersCount(string path)
    {
        WWWWrapper wrapper;
        if (_wwwWrappers.TryGetValue(path, out wrapper))
        {
            return wrapper.GetReferenceCount();
        }
        else
        {
            return 0;
        }
    }

    public void DestroyWWW(string path, object owner)
    {
        WWWWrapper wrapper;
        if (_wwwWrappers.TryGetValue(path, out wrapper))
        {
            wrapper.DestroyReference(owner);

            if (wrapper.IsAllDestroyed())
            {
                DestroyAllWWW(path);
            }
        }
    }

    private void DestroyAllWWW(string path)
    {
        WWWWrapper wrapper = null;
        if (_wwwWrappers.TryGetValue(path, out wrapper))
        {
            if (wrapper.loadDone)
            {
                Object.Destroy(wrapper.asset.asset);
                _wwwWrappers.Remove(path);
            }
            else
            {
                wrapper.DestroyAllReference();
            }
        }
        else
        {
            throw new Exception("WWW not found");
        }
    }

    public IPromise<T> GetWWWAsset<T>(string path, object owner) where T : UnityEngine.Object
    {
        WWWWrapper wwwWrapper = null;

        int id = GetNextIDWWW();
        if (_wwwWrappers.TryGetValue(path, out wwwWrapper))
        {
            wwwWrapper.AddReference(owner, id);

            if (wwwWrapper.loadDone)
            {
                return RetriveWWW<T>(wwwWrapper, path, owner, id);
            }
            else
            {
                return DelayRetriveWWW<T>(wwwWrapper, path, owner, id);
            }
        }
        else
        {
            return BrandNewLoadWWW<T>(path, owner, id);
        }
    }

    private IPromise<T> RetriveWWW<T>(WWWWrapper wwwWrapper, string path, object owner, int id) where T : Object
    {
        var promise = new Promise<T>();

        var asset = wwwWrapper.asset.asset;
        if (asset)
        {
            if (IsTargetDestroyed(wwwWrapper, owner, id))
            {
                promise.Reject(new TargetDestroyedException(null, owner));
            }
            else
            {
                T result = asset as T;
                if (result)
                {
                    promise.Resolve(result);
                }
                else
                {
                    promise.Reject(new WWWAssetException(path));
                }
            }
        }
        else
        {
            promise.Reject(new UnknownException("WWW Asset dead: " + path));
        }

        return promise;
    }

    private void AddLoadDoneAction<T>(Promise<T> promise, WWWWrapper wwwWrapper, string path, object owner, int id) where T : Object
    {
        Action loadDoneAction = new Action(() =>
        {
            T asset = wwwWrapper.asset.asset as T;

            if (wwwWrapper.IsAllDestroyed())
            {
                promise.Reject(new LoadDoneAndDestroyAllException());
            }
            else if (IsTargetDestroyed(wwwWrapper, owner, id))
            {
                promise.Reject(new TargetDestroyedException(null, owner));
            }
            else if (!wwwWrapper.IsContainTarget(owner, id))
            {
                promise.Reject(new LoadDoneAndDestroyMainException());
            }
            else
            {
                T result = asset;
                if (result)
                {
                    promise.Resolve(result);
                }
                else
                {
                    promise.Reject(new WWWAssetException(path));
                }
            }
        });

        wwwWrapper.loadDoneAction.Add(loadDoneAction);
    }

    private IPromise<T> DelayRetriveWWW<T>(WWWWrapper wwwWrapper, string path, object owner, int id) where T : Object
    {
        var promise = new Promise<T>();

       AddLoadDoneAction(promise, wwwWrapper, path, owner, id);

        return promise;
    }


    private IPromise<T> BrandNewLoadWWW<T>(string path, object owner, int id) where T : UnityEngine.Object
    {
        var promise = new Promise<T>();

        var wwwWrapper = new WWWWrapper()
        {
            path = path,
            asset = GetWWWObject<T>(),
            loadDone = false,
            loadDoneAction = new List<Action>(DEFAULT_LIST_SIZE),
        };
        wwwWrapper.AddReference(owner, id);
        AddLoadDoneAction(promise, wwwWrapper, path, owner, id);

        _wwwWrappers.Add(path, wwwWrapper);

        MainThreadDispatcher.StartUpdateMicroCoroutine(GetWWWInternal(path));

        return promise;
    }

    private IEnumerator GetWWWInternal(string path)
    {
        var www = new WWW(path);
        while (!www.isDone)
        {
            yield return null;
        }

        if (string.IsNullOrEmpty(www.error))
        {
            var wrapper = _wwwWrappers[path];
            Assert.IsNotNull(wrapper);

            if (wrapper.IsAllDestroyed())
            {
                www.Dispose();
            }
            else
            {
                wrapper.asset.GenerateAsset(www);
                www.Dispose();
            }

            wrapper.loadDone = true;

            if (wrapper.loadDoneAction != null)
            {
                for (int i = 0, length = wrapper.loadDoneAction.Count; i < length; ++i)
                {
                    wrapper.loadDoneAction[i]();
                }
                wrapper.loadDoneAction = null;
            }

            if (wrapper.IsAllDestroyed())
            {
                Object.Destroy(wrapper.asset.asset);
                _wwwWrappers.Remove(path);
            }
        }
        else
        {
            www.Dispose();
        }
    }

    private WWWResource GetWWWObject<T>()
    {
        if (typeof(T) == typeof(Texture2D))
        {
            return new WWWTexture();
        }
        else if (typeof(T) == typeof(AudioClip))
        {
            return new WWWAudioClip();
        }
        else
        {
            throw new Exception("!!! cannot get asset for: " + typeof(T));
        }
    }


    private static bool IsTargetDestroyed(WWWWrapper wrapper, object owner, int id)
    {
        return !wrapper.IsContainTarget(owner, id);
    }

    private static int _idWWW= 0;

    private static int GetNextIDWWW()
    {
        _idWWW = _idWWW + 1;

        return _idWWW;
    }
}
