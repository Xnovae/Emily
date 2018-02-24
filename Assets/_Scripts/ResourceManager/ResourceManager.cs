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
    public const int DEFAULT_LIST_SIZE = 4;

    private static ResourceManager _instance;

    public static ResourceManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ResourceManager();
            }

            return _instance;
        }
    }

    private AssetBundleManifest _assetBundleManifest;

    private ResourceManager()
    { }

    public IPromise InitAssetBundleManifest(string assetBundleManifestPath, object owner)
    {
        var promise = new Promise();

        if (_assetBundleManifest)
        {
            promise.Resolve();
        }

        GetAssetBundleManifest(assetBundleManifestPath, owner)
            .Then(manifest =>
            {
                _assetBundleManifest = manifest;

                promise.Resolve();
            })
            .Catch(ex =>
            {
                Debug.LogException(ex);
                promise.Reject(new Exception("AssetBundleManifest not found: " + assetBundleManifestPath));
            });

        return promise;
    }

    private IPromise<AssetBundleManifest> GetAssetBundleManifest(string path, object owner)
    {
        var promise = new Promise<AssetBundleManifest>();

        GetAssetBundleAsset(path, "AssetBundleManifest", owner)
            .Then(obj =>
            {
                var manifest = obj as AssetBundleManifest;

                if (manifest)
                {
                    promise.Resolve(manifest);
                }
                else
                {
                    promise.Reject(new Exception("empty assetbundle manefest: " + path));
                }
            });

        return promise;
    }
}
