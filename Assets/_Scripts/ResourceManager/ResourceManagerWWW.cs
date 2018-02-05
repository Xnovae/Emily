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

        private List<int> _validRefCountList = new List<int>(DEFAULT_LIST_SIZE);

        public void DestroyAllReference()
        {
            _validRefCountList.Clear();
        }

        public void DestroyReference()
        {
            if (_validRefCountList.Count > 0)
            {
                _validRefCountList.RemoveAt(0);
            }
        }

        public void AddReference(int refCount)
        {
            Assert.IsFalse(_validRefCountList.Contains(refCount));

            _validRefCountList.Add(refCount);
        }

        public bool IsAllDestroyed()
        {
            return _validRefCountList.Count == 0;
        }

        public bool IsContainTarget(int refCount)
        {
            return _validRefCountList.Contains(refCount);
        }

        public int GetReferenceCount()
        {
            return _validRefCountList.Count;
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

    public void DestroyWWW(string path)
    {
        WWWWrapper wrapper;
        if (_wwwWrappers.TryGetValue(path, out wrapper))
        {
            wrapper.DestroyReference();

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

    public IPromise<T> GetWWWAsset<T>(string path) where T : UnityEngine.Object
    {
        WWWWrapper wwwWrapper = null;

        int refCount = GetNextIdWWW();

        if (_wwwWrappers.TryGetValue(path, out wwwWrapper))
        {
            wwwWrapper.AddReference(refCount);

            if (wwwWrapper.loadDone)
            {
                return RetriveWWW<T>(wwwWrapper, path, refCount);
            }
            else
            {
                return DelayRetriveWWW<T>(wwwWrapper, path, refCount);
            }
        }
        else
        {
            return BrandNewLoadWWW<T>(path, refCount);
        }
    }

    private IPromise<T> RetriveWWW<T>(WWWWrapper wwwWrapper, string path, int refCount) where T : Object
    {
        var promise = new Promise<T>();

        var asset = wwwWrapper.asset.asset;
        if (asset)
        {
            if (IsTargetDestroyed(wwwWrapper, refCount))
            {
                promise.Reject(new TargetDestroyedException(null, refCount));
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

    private void AddLoadDoneAction<T>(Promise<T> promise, WWWWrapper wwwWrapper, string path, int refCount) where T : Object
    {
        Action loadDoneAction = new Action(() =>
        {
            T asset = wwwWrapper.asset.asset as T;

            if (wwwWrapper.IsAllDestroyed())
            {
                promise.Reject(new LoadDoneAndDestroyAllException());
            }
            else if (IsTargetDestroyed(wwwWrapper, refCount))
            {
                promise.Reject(new TargetDestroyedException(null, refCount));
            }
            else if (!wwwWrapper.IsContainTarget(refCount))
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

    private IPromise<T> DelayRetriveWWW<T>(WWWWrapper wwwWrapper, string path, int refCount) where T : Object
    {
        var promise = new Promise<T>();

       AddLoadDoneAction(promise, wwwWrapper, path, refCount);

        return promise;
    }


    private IPromise<T> BrandNewLoadWWW<T>(string path, int refCount) where T : UnityEngine.Object
    {
        var promise = new Promise<T>();

        var wwwWrapper = new WWWWrapper()
        {
            path = path,
            asset = GetWWWObject<T>(),
            loadDone = false,
            loadDoneAction = new List<Action>(DEFAULT_LIST_SIZE),
        };
        wwwWrapper.AddReference(refCount);
        AddLoadDoneAction(promise, wwwWrapper, path, refCount);

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
        else if (typeof(T) == typeof(MovieTexture))
        {
           return new WWWMovieTexture(); 
        }
        else
        {
            throw new Exception("!!! cannot get asset for: " + typeof(T));
        }
    }


    private static bool IsTargetDestroyed(WWWWrapper wrapper, int refCount)
    {
        return !wrapper.IsContainTarget(refCount);
    }
}
