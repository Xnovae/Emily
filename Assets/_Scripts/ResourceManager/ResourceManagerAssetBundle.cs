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
        public string path;
        public AssetBundle assetBundle;

        public bool loadDone;
        public List<Action> loadDoneAction;

        private List<object> _referenceList = new List<object>(DEFAULT_LIST_SIZE);
        private List<string> _loadingAssets = new List<string>(DEFAULT_LIST_SIZE);

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
            bool removed = _referenceList.Remove(owner);
            Assert.IsTrue(removed, string.Format("remove {0} is not exist", owner));
        }

        public void AddReference(object owner)
        {
            Assert.IsFalse(_referenceList.Contains(owner));
            _referenceList.Add(owner);
        }

        public int GetReferenceCount()
        {
            return _referenceList.Count;
        }

        public bool IsAllDestroyed()
        {
            return _referenceList.Count == 0;
        }

        public bool IsContainTarget(object owner)
        {
            return _referenceList.Contains(owner);
        }
    }

    class DependencyAssetBundleWrapper
    {
        public AssetBundle assetBundle;
        public bool loadDone;

        private int _referenceCount;

        public void SetReferenceCount(int count)
        {
            _referenceCount = Mathf.Max(0, count);
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

    public IPromise<AssetBundle> GetAssetBundle(string path, object owner)
    {
        return GetAssetBundle(path, false, owner);
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

        if (_assetBundleWrappers.TryGetValue(path, out assetBundleWrapper))
        {
            assetBundleWrapper.AddReference(owner);

            if (assetBundleWrapper.loadDone)
            {
                return RetriveAssetBundle(assetBundleWrapper, path, owner);
            }
            else
            {
                return DelayRetriveAssetBundle(assetBundleWrapper, path, owner);
            }
        }
        else
        {
            return BrandNewLoadAssetBundle(path, isManifestBundle, isDependency, owner);
        }
    }

    private IPromise<AssetBundle> BrandNewLoadAssetBundle(string path, bool isManifestBundle, bool isDependency, object owner)
    {
        var promise = new Promise<AssetBundle>();

        var assetBundleWrapper = new AssetBundleWrapper()
        {
            path = path,
            assetBundle = null,
            loadDone = false,
            loadDoneAction = new List<Action>(DEFAULT_LIST_SIZE),
        };
        assetBundleWrapper.AddReference(owner);
        AddLoadDoneAction(promise, assetBundleWrapper, path, owner);

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

    private void AddLoadDoneAction(Promise<AssetBundle> promise, AssetBundleWrapper assetBundleWrapper, string path, object owner)
    {
        Action loadDoneAction = new Action(() =>
        {
            AssetBundle assetBundle = assetBundleWrapper.assetBundle;

            if (assetBundleWrapper.IsAllDestroyed())
            {
                promise.Reject(new LoadDoneAndDestroyAllException());
            }
            else if (IsTargetDestroyed(assetBundleWrapper, owner))
            {
                promise.Reject(new TargetDestroyedException(assetBundle, owner));
            }
            else if (!assetBundleWrapper.IsContainTarget(owner))
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

    private IPromise<AssetBundle> DelayRetriveAssetBundle(AssetBundleWrapper assetBundleWrapper, string path, object owner)
    {
        var promise = new Promise<AssetBundle>();

        AddLoadDoneAction(promise, assetBundleWrapper, path, owner);

        return promise;
    }

    private IPromise<AssetBundle> RetriveAssetBundle(AssetBundleWrapper assetBundleWrapper, string path, object owner)
    {
        var promise = new Promise<AssetBundle>();

        var assetBundle = assetBundleWrapper.assetBundle;
        if (assetBundle)
        {
            if (IsTargetDestroyed(assetBundleWrapper, owner))
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
        AssetBundleCreateRequest[] requests;
        string[] dependenciesURI = null;
        if (isManifestBundle)
        {
            requests = new AssetBundleCreateRequest[1] { AssetBundle.LoadFromFileAsync(path) };
        }
        else
        {
            string pathPrefix = Utils.GetBundlePathForLoadFromFile("");
            string assetBundleName = path.Substring(pathPrefix.Length);

            dependenciesURI = _assetBundleManifest.GetAllDependencies(assetBundleName);
            for(int i=0, count = dependenciesURI.Length; i<count; ++i)
            {
                dependenciesURI[i] = Utils.GetBundlePathForLoadFromFile(dependenciesURI[i]);
            }

            requests = new AssetBundleCreateRequest[dependenciesURI.Length + 1];    // last one contains self AssetBundle
            // dependency
            int length = requests.Length;
            for (int i = 0; i < length - 1; ++i)
            {
                string depencyURI = dependenciesURI[i];
                DependencyAssetBundleWrapper wrapper;
                if (_dependenciesWrappers.TryGetValue(depencyURI, out wrapper))
                {
                    int count = wrapper.GetReferenceCount();
                    wrapper.SetReferenceCount(count + 1);

                    requests[i] = null;
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
                    _dependenciesWrappers.Add(dependenciesURI[i], wrapper);

                    requests[i] = AssetBundle.LoadFromFileAsync(depencyURI);
                }
            }
            // self
            requests[length - 1] = AssetBundle.LoadFromFileAsync(path);
            if (isDependency)
            {
                var wrapper = new DependencyAssetBundleWrapper()
                {
                    assetBundle = null,
                    loadDone = false,
                };
                wrapper.SetReferenceCount(1);

                _dependenciesWrappers.Add(path, wrapper);
            }
        }

        while (!AllRequestsDone(requests, dependenciesURI))
        {
            yield return null;
        }

        // process dependency AssetBundle
        if(dependenciesURI != null)
        {
            for(int i=0, count = dependenciesURI.Length; i<count; ++i)
            {
                if(requests[i] != null)
                {
                    var wrapper = _dependenciesWrappers[dependenciesURI[i]];
                    Assert.IsNotNull(wrapper);

                    wrapper.assetBundle = requests[i].assetBundle;
                    Assert.IsNotNull(wrapper.assetBundle);
                    wrapper.loadDone = true;
                }
            }
        }

        // self is dependency
        if (isDependency)
        {
            var wrapper = _dependenciesWrappers[path];
            Assert.IsNotNull(wrapper);

            int length = requests.Length;
            wrapper.assetBundle = requests[length - 1].assetBundle;
            Assert.IsNotNull(wrapper.assetBundle);
            wrapper.loadDone = true;
        }

        AssetBundle assetBundle = requests[requests.Length - 1].assetBundle;

        var wwwWrapper = _assetBundleWrappers[path];
        Assert.IsNotNull(wwwWrapper);

        wwwWrapper.assetBundle = assetBundle;
        Assert.IsNotNull(wwwWrapper.assetBundle);
        wwwWrapper.loadDone = true;

        if (wwwWrapper.loadDoneAction != null)
        {
            for (int i = 0, length = wwwWrapper.loadDoneAction.Count; i < length; ++i)
            {
                wwwWrapper.loadDoneAction[i]();
            }
            wwwWrapper.loadDoneAction = null;
        }

        if (wwwWrapper.IsAllDestroyed())
        {
            _assetBundleWrappers.Remove(path);

            assetBundle.Unload(true);
            DestroyDependency(path);
        }
    }

    private bool AllRequestsDone(AssetBundleCreateRequest[] requests, string[] dependenciesURI)
    {
        int length = requests.Length;
        if (requests[length - 1].isDone == false)
            return false;

        for(int i=0; i<length - 1; ++i)
        {
            if (requests[i] == null)
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
                if (requests[i].isDone == false)
                {
                    return false;
                }
            }

        }

        return true;
    }

    private static bool IsTargetDestroyed(AssetBundleWrapper wrapper, object owner)
    {
        return !wrapper.IsContainTarget(owner);
    }

    // ====================== Utils ================================
}
