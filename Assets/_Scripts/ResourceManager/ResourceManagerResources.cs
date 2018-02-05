using System;
using System.Collections;
using System.Collections.Generic;
using RSG;
using UniRx;
using UnityEngine;
using UnityEngine.Assertions;
using System.IO;

using Object = UnityEngine.Object;

public partial class ResourceManager
{
    class ResourcesWrapper
    {
        public string path;
        public Object asset;

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

    private Dictionary<string, ResourcesWrapper> _resourcesWrappers = new Dictionary<string, ResourcesWrapper>();

    public int GetResourcesWrappersCount(string path)
    {
        ResourcesWrapper wrapper;
        if (_resourcesWrappers.TryGetValue(path, out wrapper))
        {
            return wrapper.GetReferenceCount();
        }
        else
        {
            return 0;
        }
    }

    private static int _idResources = 0;

    private static int GetNextIdResources()
    {
        ++_idResources;

        return _idResources;
    }

    public IPromise<T> GetResourceAsset<T>(string path) where T : UnityEngine.Object
    {
        ResourcesWrapper resourcesWrapper = null;
        int refCount = GetNextIdResources();

        if (_resourcesWrappers.TryGetValue(path, out resourcesWrapper))
        {
            resourcesWrapper.AddReference(refCount);

            if (resourcesWrapper.loadDone)
            {
                return RetriveResources<T>(resourcesWrapper, path, refCount);
            }
            else
            {
                return DelayRetriveResources<T>(resourcesWrapper, path, refCount);
            }
        }
        else
        {
            return BrandNewLoadResources<T>(path, refCount);
        }
    }

    private void AddLoadDoneAction<T>(Promise<T> promise, ResourcesWrapper resourcesWrapper, string path, int refCount) where T : Object
    {
        Action loadDoneAction = new Action(() =>
        {
            Object asset = resourcesWrapper.asset;

            if (resourcesWrapper.IsAllDestroyed())
            {
                promise.Reject(new LoadDoneAndDestroyAllException());
            }
            else if (IsTargetDestroyed(resourcesWrapper, refCount))
            {
                promise.Reject(new TargetDestroyedException(null, refCount));
            }
            else if (!resourcesWrapper.IsContainTarget(refCount))
            {
                promise.Reject(new LoadDoneAndDestroyMainException());
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
                    promise.Reject(new ResourcesAssetException(path));
                }
            }
        });

        resourcesWrapper.loadDoneAction.Add(loadDoneAction);
    }

    private IPromise<T> DelayRetriveResources<T>(ResourcesWrapper resourcesWrapper, string path, int refCount) where T : Object
    {
        var promise = new Promise<T>();

       AddLoadDoneAction(promise, resourcesWrapper, path, refCount); 

        return promise;
    }

    private IPromise<T> RetriveResources<T>(ResourcesWrapper resourcesWrapper, string path, int refCount) where T : Object
    {
        var promise = new Promise<T>();

        var asset = resourcesWrapper.asset;
        if (asset)
        {
            if (IsTargetDestroyed(resourcesWrapper, refCount))
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
                    promise.Reject(new ResourcesAssetException(path));
                }
            }
        }
        else
        {
            promise.Reject(new UnknownException("Resources Asset dead: " + path));
        }

        return promise;
    }

    private IPromise<T> BrandNewLoadResources<T>(string path, int refCount) where T : UnityEngine.Object
    {
        var promise = new Promise<T>();

        var resourcesWrapper = new ResourcesWrapper()
        {
            path = path,
            asset = null,
            loadDone = false,
            loadDoneAction = new List<Action>(DEFAULT_LIST_SIZE),
        };
        resourcesWrapper.AddReference(refCount);
        AddLoadDoneAction(promise, resourcesWrapper, path, refCount);

        _resourcesWrappers.Add(path, resourcesWrapper);

        MainThreadDispatcher.StartUpdateMicroCoroutine(GetResourcesInternal<T>(path));

        return promise;
    }

    private IEnumerator GetResourcesInternal<T>(string path) where T : UnityEngine.Object
    {
        var request = Resources.LoadAsync<T>(path);
        while (!request.isDone)
        {
            yield return null;
        }

        var wrapper = _resourcesWrappers[path];
        Assert.IsNotNull(wrapper);

        T asset = request.asset as T;
        wrapper.asset = asset;

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
            Resources.UnloadAsset(wrapper.asset);
            _resourcesWrappers.Remove(path);
        }
    }

    public void DestroyResourceAsset(string path)
    {
        ResourcesWrapper wrapper;
        if (_resourcesWrappers.TryGetValue(path, out wrapper))
        {
            wrapper.DestroyReference();

            if (wrapper.IsAllDestroyed())
            {
                DestroyAllResources(path);
            }
        }
    }

    private void DestroyAllResources(string path)
    {
        ResourcesWrapper wrapper = null;
        if (_resourcesWrappers.TryGetValue(path, out wrapper))
        {
            if (wrapper.loadDone)
            {
                Resources.UnloadAsset(wrapper.asset);
                _resourcesWrappers.Remove(path);
            }
            else
            {
                wrapper.DestroyAllReference();
            }
        }
        else
        {
            throw new Exception("resources not found");
        }
    }

    private static bool IsTargetDestroyed(ResourcesWrapper wrapper, int refCount)
    {
        return !wrapper.IsContainTarget(refCount);
    }

}
