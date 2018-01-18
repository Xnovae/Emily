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

    class WWWMovieTexture : WWWResource
    {
        public override void GenerateAsset(WWW www)
        {
            Assert.IsNotNull(www);
            Assert.IsTrue(string.IsNullOrEmpty(www.error));

            asset = www.GetMovieTexture();
        }
    }

    class WWWWrapper
    {
        public string path;
        public WWWResource asset;

        public bool loadDone;
        public List<Action> loadDoneAction;

        private List<UnityEngine.Object> _referenceObjects = new List<Object>(DEFAULT_LIST_SIZE);
        private List<int> _validRefCountList = new List<int>(DEFAULT_LIST_SIZE);

        public void DestroyAllReference()
        {
            _referenceObjects.Clear();
            _validRefCountList.Clear();
        }

        public void DestroyReference(UnityEngine.Object obj)
        {
            System.Object rawObj = obj;
            if (rawObj == null)
            {
                if (_validRefCountList.Count > 0)
                {
                    _validRefCountList.RemoveAt(0);
                }
            }
            else
            {
                _referenceObjects.Remove(obj);
            }
        }

        public void AddReference(UnityEngine.Object obj, int refCount)
        {
            System.Object rawObj = obj;
            if (rawObj == null)
            {
                Assert.IsFalse(_validRefCountList.Contains(refCount));

                _validRefCountList.Add(refCount);
            }
            else
            {
                if (!_referenceObjects.Contains(obj))
                    _referenceObjects.Add(obj);
            }
        }

        public bool IsAllDestroyed()
        {
            return _referenceObjects.Count == 0 && _validRefCountList.Count == 0;
        }

        public bool IsContainTarget(UnityEngine.Object obj, int refCount)
        {
            System.Object rawObj = obj;
            if (rawObj == null)
            {
                return _validRefCountList.Contains(refCount);
            }
            else
            {
                return _referenceObjects.Contains(obj);
            }
        }

        public int GetReferenceCount()
        {
            return _referenceObjects.Count + _validRefCountList.Count;
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

    private static int _idWWW = 0;

    private static int GetNextIdWWW()
    {
        ++_idWWW;

        return _idWWW;
    }

    public void DestroyWWW(UnityEngine.Object target, string path)
    {
        WWWWrapper wrapper;
        if (_wwwWrappers.TryGetValue(path, out wrapper))
        {
            wrapper.DestroyReference(target);

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

    public IPromise<T> GetWWWAsset<T>(UnityEngine.Object target, string path) where T : UnityEngine.Object
    {
        WWWWrapper wwwWrapper = null;

        int refCount = GetNextIdWWW();

        if (_wwwWrappers.TryGetValue(path, out wwwWrapper))
        {
            wwwWrapper.AddReference(target, refCount);

            if (wwwWrapper.loadDone)
            {
                return RetriveWWW<T>(wwwWrapper, target, path, refCount);
            }
            else
            {
                return DelayRetriveWWW<T>(wwwWrapper, target, path, refCount);
            }
        }
        else
        {
            return BrandNewLoadWWW<T>(target, path, refCount);
        }
    }

    private IPromise<T> RetriveWWW<T>(WWWWrapper wwwWrapper, Object target, string path, int refCount) where T : Object
    {
        var promise = new Promise<T>();

        var asset = wwwWrapper.asset.asset;
        if (asset)
        {
            if (IsTargetDestroyed(target, wwwWrapper, refCount))
            {
                promise.Reject(new TargetDestroyedException(null, asset));
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

    private void AddLoadDoneAction<T>(Promise<T> promise, WWWWrapper wwwWrapper, Object target, string path, int refCount) where T : Object
    {
        Action loadDoneAction = new Action(() =>
        {
            T asset = wwwWrapper.asset.asset as T;

            CheckTargetDestroy(wwwWrapper, target);

            if (wwwWrapper.IsAllDestroyed())
            {
                promise.Reject(new LoadDoneAndDestroyAllException());
            }
            else if (IsTargetDestroyed(target, wwwWrapper, refCount))
            {
                promise.Reject(new TargetDestroyedException(null, asset));
            }
            else if (!wwwWrapper.IsContainTarget(target, refCount))
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

    private void CheckTargetDestroy(WWWWrapper wwwWrapper, Object target)
    {
        object rawTarget = target;
        if (rawTarget == null && !target)
        {
            wwwWrapper.DestroyReference(target);
        }
    }

    private IPromise<T> DelayRetriveWWW<T>(WWWWrapper wwwWrapper, Object target, string path, int refCount) where T : Object
    {
        var promise = new Promise<T>();

       AddLoadDoneAction(promise, wwwWrapper, target, path, refCount);

        return promise;
    }


    private IPromise<T> BrandNewLoadWWW<T>(Object target, string path, int refCount) where T : UnityEngine.Object
    {
        var promise = new Promise<T>();

        var wwwWrapper = new WWWWrapper()
        {
            path = path,
            asset = GetWWWObject<T>(),
            loadDone = false,
            loadDoneAction = new List<Action>(DEFAULT_LIST_SIZE),
        };
        wwwWrapper.AddReference(target, refCount);
        AddLoadDoneAction(promise, wwwWrapper, target, path, refCount);

        _wwwWrappers.Add(path, wwwWrapper);

        MainThreadDispatcher.StartUpdateMicroCoroutine(GetWWWInternal(target, path));

        return promise;
    }

    private IEnumerator GetWWWInternal(Object target, string path)
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
        else if (typeof(T) == typeof(MovieTexture))
        {
           return new WWWMovieTexture(); 
        }
        else
        {
            throw new Exception("!!! cannot get asset for: " + typeof(T));
        }
    }


    private static bool IsTargetDestroyed(UnityEngine.Object target, WWWWrapper wrapper, int refCount)
    {
        System.Object targetRaw = target as System.Object;
        if (targetRaw == null)
        {
            return !wrapper.IsContainTarget(target, refCount);
        }
        else
        {
            if (target)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
