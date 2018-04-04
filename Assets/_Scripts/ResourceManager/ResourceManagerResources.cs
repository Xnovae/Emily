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
        class RefData
        {
            public object owner;
            public List<int> internalRefList = new List<int>(DEFAULT_LIST_SIZE);
        }

        public string path;
        public Object asset;

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

    public IPromise<T> GetResourceAsset<T>(string path, object owner) where T : UnityEngine.Object
    {
        Assert.IsFalse(typeof(T) == typeof(GameObject), "Unity Can NOT UnloadAsset GameObject, Please use Resources.Load<GameObject>()");
        Assert.IsFalse(typeof(T) == typeof(Component), "Unity Can NOT UnloadAsset Component, Please use Resources.Load<Component>()");
        Assert.IsFalse(typeof(T) == typeof(AssetBundle), "Unity Can NOT UnloadAsset AssetBundle, Please use Resources.Load<AssetBundle>()");

        ResourcesWrapper resourcesWrapper = null;

        int id = GetNextIDResources();

        if (_resourcesWrappers.TryGetValue(path, out resourcesWrapper))
        {
            resourcesWrapper.AddReference(owner, id);

            if (resourcesWrapper.loadDone)
            {
                return RetriveResources<T>(resourcesWrapper, path, owner, id);
            }
            else
            {
                return DelayRetriveResources<T>(resourcesWrapper, path, owner, id);
            }
        }
        else
        {
            return BrandNewLoadResources<T>(path, owner, id);
        }
    }

    private void AddLoadDoneAction<T>(Promise<T> promise, ResourcesWrapper resourcesWrapper, string path, object owner, int id) where T : Object
    {
        Action loadDoneAction = new Action(() =>
        {
            Object asset = resourcesWrapper.asset;

            if (resourcesWrapper.IsAllDestroyed())
            {
                promise.Reject(new LoadDoneAndDestroyAllException());
            }
            else if (IsTargetDestroyed(resourcesWrapper, owner, id))
            {
                promise.Reject(new TargetDestroyedException(null, owner));
            }
            else if (!resourcesWrapper.IsContainTarget(owner, id))
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

    private IPromise<T> DelayRetriveResources<T>(ResourcesWrapper resourcesWrapper, string path, object owner, int id) where T : Object
    {
        var promise = new Promise<T>();

       AddLoadDoneAction(promise, resourcesWrapper, path, owner, id); 

        return promise;
    }

    private IPromise<T> RetriveResources<T>(ResourcesWrapper resourcesWrapper, string path, object owner, int id) where T : Object
    {
        var promise = new Promise<T>();

        var asset = resourcesWrapper.asset;
        if (asset)
        {
            if (IsTargetDestroyed(resourcesWrapper, owner, id))
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

    private IPromise<T> BrandNewLoadResources<T>(string path, object owner, int id) where T : UnityEngine.Object
    {
        var promise = new Promise<T>();

        var resourcesWrapper = new ResourcesWrapper()
        {
            path = path,
            asset = null,
            loadDone = false,
            loadDoneAction = new List<Action>(DEFAULT_LIST_SIZE),
        };
        resourcesWrapper.AddReference(owner, id);
        AddLoadDoneAction(promise, resourcesWrapper, path, owner, id);

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

    public void DestroyResourceAsset(string path, object owner)
    {
        ResourcesWrapper wrapper;
        if (_resourcesWrappers.TryGetValue(path, out wrapper))
        {
            wrapper.DestroyReference(owner);

            if (wrapper.IsAllDestroyed())
            {
                DestroyAllResources(path);
            }
        }
        else
        {
            throw new Exception(string.Format("DestroyResourceAsset path: {0} owner: {1}", path, owner));
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

    private static bool IsTargetDestroyed(ResourcesWrapper wrapper, object owner, int id)
    {
        return !wrapper.IsContainTarget(owner, id);
    }

    private static int _idResources= 0;

    private static int GetNextIDResources()
    {
        _idResources = _idResources + 1;

        return _idResources;
    }

}
