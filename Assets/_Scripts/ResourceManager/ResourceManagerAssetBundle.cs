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
    public IPromise<UnityEngine.Object> GetAssetBundleAsset(string path, string assetName, object owner)
    {
        return GetAssetBundle(path, assetName == "AssetBundleManifest", false, owner)
            .Then(assetBundle => LoadBundleAsset(assetBundle, path, assetName));
    }

    private IPromise<Object> LoadBundleAsset(AssetBundle assetBundle, string path, string assetName)
    {
        var promise = new Promise<Object>();

        MainThreadDispatcher.StartUpdateMicroCoroutine(LoadBundleAssetInternal(promise, assetBundle, path, assetName));

        return promise;
    }

    private IEnumerator LoadBundleAssetInternal(Promise<Object> promise, AssetBundle assetBundle, string path, string assetName)
    {
        if (!_assetBundleWrappers.ContainsKey(path))
        {
            promise.Reject(new Exception(
                string.Format("cannot load AssetBundle Asset when assetBundle destroyed path:{0} assetName: {1}", path, assetName)));
            yield break;
        }

        var wrapper = _assetBundleWrappers[path];
        Assert.IsNotNull(wrapper);
        Assert.AreEqual(wrapper.assetBundle, assetBundle);

        wrapper.AddLoadingAssets(assetName);

        var request = assetBundle.LoadAssetAsync<Object>(assetName);
        while (!request.isDone)
        {
            yield return null;
        }

        wrapper.RemoveLoadingAssets(assetName);
        if (wrapper.IsAllDestroyed())
        {
            if (wrapper.GetLoadingAssetsCount() == 0)
            {
                DestroyAllAssetBundle(path);
            }
            else
            {
                // still got loading assets, skip
            }

            promise.Reject(new Exception("AssetBundle asset load done and AssetBundle Unloaded: " + assetName));
        }
        else
        {
            Object obj = request.asset;

            if (obj)
            {
                promise.Resolve(obj);
            }
            else
            {
                promise.Reject(new LoadAssetBundleAssetException());
            }
        }
    }


    class AssetBundleWrapper
    {
        class RefData
        {
            public object owner;
            public List<int> internalRefList = new List<int>(DEFAULT_LIST_SIZE);
        }

        public string path;
        public AssetBundle assetBundle;

        public bool loadDone;
        public List<Action> loadDoneAction;

        private List<RefData> _referenceList = new List<RefData>(DEFAULT_LIST_SIZE);
        private List<string> _loadingAssets = new List<string>(DEFAULT_LIST_SIZE);

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

        public void AddLoadingAssets(string assetName)
        {
            _loadingAssets.Add(assetName);
        }

        public void RemoveLoadingAssets(string assetName)
        {
            Assert.IsTrue(_loadingAssets.Contains(assetName));
            _loadingAssets.Remove(assetName);
        }

        public int GetLoadingAssetsCount()
        {
            return _loadingAssets.Count;
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
                refData = new RefData {owner = owner};
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

        public int GetReferenceCount()
        {
            int refCount = 0;
            for(int i=0, length = _referenceList.Count; i<length; ++i)
            {
                refCount += _referenceList[i].internalRefList.Count;
            }

            return refCount;
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
    }

    class DependencyAssetBundleWrapper
    {
        public AssetBundle assetBundle;
        public bool loadDone;

        private int _referenceCount;

        public void SetReferenceCount(int count)
        {
            Assert.IsTrue(count >= 0);
            _referenceCount = count;
        }

        public int GetReferenceCount()
        {
            return _referenceCount;
        }

        public bool IsAllDestroyed()
        {
            return _referenceCount == 0;
        }
    }

    private Dictionary<string, AssetBundleWrapper> _assetBundleWrappers = new Dictionary<string, AssetBundleWrapper>();
    private Dictionary<string, DependencyAssetBundleWrapper> _dependenciesWrappers = new Dictionary<string, DependencyAssetBundleWrapper>();

    public int GetAssetBundleWrappersCount(string path)
    {
        AssetBundleWrapper wrapper;
        if (_assetBundleWrappers.TryGetValue(path, out wrapper))
        {
            return wrapper.GetReferenceCount();
        }
        else
        {
            return 0;
        }
    }

    public void DestroyAssetBundle(string path, object owner)
    {
        AssetBundleWrapper wrapper;
        if (_assetBundleWrappers.TryGetValue(path, out wrapper))
        {
            wrapper.DestroyReference(owner);

            if (wrapper.IsAllDestroyed())
            {
                DestroyAllAssetBundle(path);
            }
        }
        else
        {
            throw new Exception(string.Format("DestroyAssetBundle path: {0} owner: {1}", path, owner));
        }
    }

    private void DestroyAllAssetBundle(string path)
    {
        AssetBundleWrapper wrapper = null;
        if (_assetBundleWrappers.TryGetValue(path, out wrapper))
        {
            if (wrapper.loadDone)
            {
                if (wrapper.GetLoadingAssetsCount() == 0)
                {
                    wrapper.assetBundle.Unload(true);
                    _assetBundleWrappers.Remove(path);

                    DestroyDependency(path);
                }
                else
                {
                    wrapper.DestroyAllReference();
                }
            }
            else
            {
                wrapper.DestroyAllReference();
            }
        }
        else
        {
            throw new Exception("assetbundle not found");
        }
    }

    public IPromise<AssetBundle> GetAssetBundle(string path, bool isDependency, object owner)
    {
        return GetAssetBundle(path, false, isDependency, owner);
    }

    private IPromise<AssetBundle> GetAssetBundle(string path, bool isManifestBundle, bool isDependency, object owner)
    {
        if (!isManifestBundle && !_assetBundleManifest)
            throw new Exception("Please load assetBundle manifest first");

        AssetBundleWrapper assetBundleWrapper = null;

        int id = GetNextIDAssetBundle();

        if (_assetBundleWrappers.TryGetValue(path, out assetBundleWrapper))
        {
            assetBundleWrapper.AddReference(owner, id);

            if (assetBundleWrapper.loadDone)
            {
                return RetriveAssetBundle(assetBundleWrapper, path, owner, id);
            }
            else
            {
                return DelayRetriveAssetBundle(assetBundleWrapper, path, owner, id);
            }
        }
        else
        {
            return BrandNewLoadAssetBundle(path, isManifestBundle, isDependency, owner, id);
        }
    }

    private IPromise<AssetBundle> BrandNewLoadAssetBundle(string path, bool isManifestBundle, bool isDependency, object owner, int id)
    {
        var promise = new Promise<AssetBundle>();

        var assetBundleWrapper = new AssetBundleWrapper()
        {
            path = path,
            assetBundle = null,
            loadDone = false,
            loadDoneAction = new List<Action>(DEFAULT_LIST_SIZE),
        };
        assetBundleWrapper.AddReference(owner, id);
        AddLoadDoneAction(promise, assetBundleWrapper, path, owner, id);

        _assetBundleWrappers.Add(path, assetBundleWrapper);

        MainThreadDispatcher.StartUpdateMicroCoroutine(GetAssetBundleInternal(path, isManifestBundle, isDependency));

        return promise;
    }

    private void DestroyDependency(string path)
    {
        string assetBundleName = Path.GetFileName(path);
        string[] dependencies = _assetBundleManifest.GetAllDependencies(assetBundleName);
        for (int i = 0, count = dependencies.Length; i < count; ++i)
        {
            string uri = Utils.GetBundlePathForLoadFromFile(dependencies[i]);

            DependencyAssetBundleWrapper wrapper;
            if (_dependenciesWrappers.TryGetValue(uri, out wrapper))
            {
                int refCount = wrapper.GetReferenceCount();
                --refCount;
                wrapper.SetReferenceCount(refCount);

                // because destroy dependency can only be called in destroy AssetBundle when ab load done, so it's safe
                Assert.IsTrue(wrapper.loadDone);

                if (wrapper.IsAllDestroyed())
                {
                    wrapper.assetBundle.Unload(true);
                    _dependenciesWrappers.Remove(uri);
                }
                else
                {
                    wrapper.SetReferenceCount(refCount);
                }
            }
        }
    }

    private void AddLoadDoneAction(Promise<AssetBundle> promise, AssetBundleWrapper assetBundleWrapper, string path, object owner, int id)
    {
        Action loadDoneAction = new Action(() =>
        {
            AssetBundle assetBundle = assetBundleWrapper.assetBundle;

            if (assetBundleWrapper.IsAllDestroyed())
            {
                promise.Reject(new LoadDoneAndDestroyAllException());
            }
            else if (IsTargetDestroyed(assetBundleWrapper, owner, id))
            {
                promise.Reject(new TargetDestroyedException(assetBundle, owner));
            }
            else if (!assetBundleWrapper.IsContainTarget(owner, id))
            {
                promise.Reject(new LoadDoneAndDestroyMainException());
            }
            else
            {
                if (assetBundle)
                {
                    promise.Resolve(assetBundle);
                }
                else
                {
                    promise.Reject(new LoadAssetBundleException(path));
                }
            }
        });

        assetBundleWrapper.loadDoneAction.Add(loadDoneAction);
    }

    private IPromise<AssetBundle> DelayRetriveAssetBundle(AssetBundleWrapper assetBundleWrapper, string path, object owner, int id)
    {
        var promise = new Promise<AssetBundle>();

        AddLoadDoneAction(promise, assetBundleWrapper, path, owner, id);

        return promise;
    }

    private IPromise<AssetBundle> RetriveAssetBundle(AssetBundleWrapper assetBundleWrapper, string path, object owner, int id)
    {
        var promise = new Promise<AssetBundle>();

        var assetBundle = assetBundleWrapper.assetBundle;
        if (assetBundle)
        {
            if (IsTargetDestroyed(assetBundleWrapper, owner, id))
            {
                promise.Reject(new TargetDestroyedException(assetBundle, owner));
            }
            else
            {
                promise.Resolve(assetBundle);
            }
        }
        else
        {
           promise.Reject(new LoadAssetBundleException(path)); 
        }

        return promise;
    }

    private IEnumerator GetAssetBundleInternal(string path, bool isManifestBundle, bool isDependency)
    {
        string[] dependenciesURI = GetAllDependenciesURI(path, isManifestBundle); ;
        AssetBundleCreateRequest[] requests = GetAssetBundleRequests(path, isManifestBundle, isDependency, dependenciesURI);

        while (!AllRequestsDone(requests, dependenciesURI, isDependency, path))
        {
            yield return null;
        }

        // process dependency AssetBundle
        int dependencyLength = isDependency ? requests.Length : requests.Length - 1;
        for (int i = 0; i < dependencyLength; ++i)
        {
            if (requests[i] != null)
            {
                string dependencyURI = GetDependencyURI(dependenciesURI, i, path);

                var wrapper = _dependenciesWrappers[dependencyURI];
                Assert.IsNotNull(wrapper);

                wrapper.assetBundle = requests[i].assetBundle;
                Assert.IsNotNull(wrapper.assetBundle);
                wrapper.loadDone = true;
            }
        }

        // process self
        AssetBundle assetBundle = requests[requests.Length - 1].assetBundle;

        var wwwWrapper = _assetBundleWrappers[path];
        Assert.IsNotNull(wwwWrapper);

        wwwWrapper.assetBundle = assetBundle;
        Assert.IsNotNull(wwwWrapper.assetBundle);
        wwwWrapper.loadDone = true;

        // callback
        if (wwwWrapper.loadDoneAction != null)
        {
            for (int i = 0, length = wwwWrapper.loadDoneAction.Count; i < length; ++i)
            {
                wwwWrapper.loadDoneAction[i]();
            }
            wwwWrapper.loadDoneAction = null;
        }

        // check ALL destroyed
        if (wwwWrapper.IsAllDestroyed())
        {
            _assetBundleWrappers.Remove(path);

            assetBundle.Unload(true);
            DestroyDependency(path);
        }
    }

    private string GetDependencyURI(string[] dependenciesURI, int i, string path)
    {
        string dependencyURI;
        if (i < dependenciesURI.Length)
        {
            dependencyURI = dependenciesURI[i];
        }
        else if (i == dependenciesURI.Length)
        {
            dependencyURI = path;
        }
        else
        {
            throw new Exception(string.Format("i: {0} exceed dependenciesURI.Length: {1}",
                i, dependenciesURI.Length));
        }
        return dependencyURI;
    }

    private string[] GetAllDependenciesURI(string path, bool isManifestBundle)
    {
        string[] dependenciesURI;
        if (isManifestBundle)
        {
            dependenciesURI = null;
        }
        else
        {
            // TODO All AssetBundle locates in StreammingAssets, change later
            string pathPrefix = Utils.GetBundlePathForLoadFromFile("");
            string assetBundleName = path.Substring(pathPrefix.Length);

            dependenciesURI = _assetBundleManifest.GetAllDependencies(assetBundleName);
            for (int i = 0, count = dependenciesURI.Length; i < count; ++i)
            {
                string originURI = dependenciesURI[i];
                dependenciesURI[i] = Utils.GetBundlePathForLoadFromFile(originURI);
            }
        }

        return dependenciesURI;
    }

    private void SetupDependency(string depencyURI, AssetBundleCreateRequest[] requests, int index)
    {
        DependencyAssetBundleWrapper wrapper;
        if (_dependenciesWrappers.TryGetValue(depencyURI, out wrapper))
        {
            int count = wrapper.GetReferenceCount();
            wrapper.SetReferenceCount(count + 1);

            requests[index] = null;
        }
        else
        {
            // dependency take place, in case of loading dependency in same time
            wrapper = new DependencyAssetBundleWrapper()
            {
                assetBundle = null,
                loadDone = false,
            };
            wrapper.SetReferenceCount(1);
            _dependenciesWrappers.Add(depencyURI, wrapper);

            requests[index] = AssetBundle.LoadFromFileAsync(depencyURI);
        }
    }

    private AssetBundleCreateRequest[] GetAssetBundleRequests(string path, bool isManifestBundle, bool isDependency, string[] dependenciesURI)
    {
        AssetBundleCreateRequest[] requests;
        if (isManifestBundle)
        {
            requests = new AssetBundleCreateRequest[1] {AssetBundle.LoadFromFileAsync(path)};
        }
        else
        {
            requests = new AssetBundleCreateRequest[dependenciesURI.Length + 1]; // last one contains self AssetBundle
            // dependency
            int length = requests.Length;
            for (int i = 0; i < length - 1; ++i)
            {
                string depencyURI = dependenciesURI[i];
                SetupDependency(depencyURI, requests, i);
            }

            // self
            if (isDependency)
            {
                SetupDependency(path, requests, length - 1);
            }
            else
            {
                requests[length - 1] = AssetBundle.LoadFromFileAsync(path);
            }
        }

        return requests;
    }

    // isDependency: is last request dependency
    private bool AllRequestsDone(AssetBundleCreateRequest[] requests, string[] dependenciesURI, bool isSelfDependency, string path)
    {
        int length = requests.Length;
        if (isSelfDependency)
        {
            // if self assetbundle is dependency, check if load done
            AssetBundleCreateRequest request = requests[length - 1];
            if (request == null)
            {
                var wrapper = _dependenciesWrappers[path];
                Assert.IsNotNull(wrapper);

                if (wrapper.loadDone == false)
                {
                    return false;
                }
            }
            else
            {
                if (request.isDone == false)
                {
                    return false;
                }
            }
        }
        else
        {
            if (requests[length - 1].isDone == false)
                return false;
        }

        // dependency
        for (int i=0; i< length - 1; ++i)
        {
            AssetBundleCreateRequest request = requests[i];
            if (request == null)
            {
                var wrapper = _dependenciesWrappers[dependenciesURI[i]];
                Assert.IsNotNull(wrapper);

                if (wrapper.loadDone == false)
                {
                    return false;
                }
            }
            else
            {
                if (request.isDone == false)
                {
                    return false;
                }
            }
        }

        return true;
    }

    private static bool IsTargetDestroyed(AssetBundleWrapper wrapper, object owner, int id)
    {
        return !wrapper.IsContainTarget(owner, id);
    }

    private static int _idAssetBundle = 0;

    private static int GetNextIDAssetBundle()
    {
        _idAssetBundle = _idAssetBundle + 1;

        return _idAssetBundle;
    }

    // ====================== Utils ================================
}
