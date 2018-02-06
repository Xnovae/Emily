using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Entitas;
using RSG;
using UniRx;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Networking;
using Object = UnityEngine.Object;

public class ResourceSystem : IInitializeSystem
{
    private GameContext _gameContext;

    public ResourceSystem(Contexts contexts)
    {
        _gameContext = contexts.game;
    }

    public void Initialize()
    {
        _gameContext.SetRunningData(new ResourceData(), new RuntimeData());

        InitializeAssetBundleManifest()             // 加载 AssetBundle Manifest
            .Then(() => InitializePoolManager())    // 生成 tk2d template
            .Then(spriteTemplate =>
            {
                _gameContext.runningData.ResourceData.spriteTemplate = spriteTemplate;

                return InitializeConfig();       // 加载所有配置
            })
            .Then(cdbPath =>
            {
                ConfigManager.Instance.Init(cdbPath);

                return InitializeShaders();
            })
            .Then(() =>
            {
                _gameContext.isResourceInitialize = true;

                _gameContext.CreateEntity().ReplaceMap("1");    // 加载地图
            })
            .Catch(ex => Debug.LogException(ex));
    }

    private IPromise<GameObject> InitializePoolManager()
    {
        var promise = new Promise<GameObject>();

        ResourceManager.Instance.GetResourceAsset<GameObject>(Consts.Tk2dSprite_Template)
            .Then(spriteTemplate =>
            {
                PoolManager.Instance.WarmPool(spriteTemplate, 50);
                promise.Resolve(spriteTemplate);
            })
            .Catch(ex =>
            {
                promise.Reject(new Exception("Fail to load tk2dSprite_template ex: " + ex));
            });

        return promise;
    }

    private IPromise InitializeAssetBundleManifest()
    {
        var promise = new Promise();

        var manifestPath = Utils.GetBundlePathForLoadFromFile("AssetBundleManifest");

        ResourceManager.Instance.InitAssetBundleManifest(manifestPath)
            .Then(() =>
            {
                promise.Resolve();
            })
            .Catch(ex =>
            {
                promise.Reject(new Exception("Fail to init AssetBundle Manifest ex: " + ex));
            });

        return promise;
    }

    private IPromise<string> InitializeConfig()
    {
        var promise = new Promise<string>();

        string sourcePath = Application.streamingAssetsPath + "/config.cdb";
        string destPath = Application.persistentDataPath + "/config.cdb";

        if (File.Exists(destPath))
        {
            promise.Resolve(destPath);
        }
        else
        {
            MainThreadDispatcher.StartUpdateMicroCoroutine(CopyConfigFiles(promise, sourcePath, destPath));
        }

        return promise;
    }

    private IEnumerator CopyConfigFiles(Promise<string> promise, string sourcePath, string destPath)
    {
        using (UnityWebRequest webRequest = new UnityWebRequest(sourcePath))
        {

            byte[] buffer = ArrayPool<byte>.Shared.Rent(64 * 1024);

            webRequest.downloadHandler = new SaveFileDownloadHandler(buffer, destPath);
            var request = webRequest.SendWebRequest();
            while (!request.isDone)
            {
                yield return null;
            }

            ArrayPool<byte>.Shared.Return(buffer);
        }

        promise.Resolve(destPath);
    }

    private IPromise InitializeShaders()
    {
        var promise = new Promise();

        var shadersAssetBundle = Utils.GetBundlePathForLoadFromFile("dependency/shaders.assetbundle");

        ResourceManager.Instance.GetAssetBundle(shadersAssetBundle)
            .Then(assetBundle =>
            {
                var obj = Resources.Load<GameObject>("quad_template");
                GameObject gameObject = Object.Instantiate(obj);

                MainThreadDispatcher.StartUpdateMicroCoroutine(WarmShaders(promise, assetBundle, gameObject));
            });

        return promise;
    }

    private IEnumerator WarmShaders(Promise promise, AssetBundle assetBundle, GameObject gameObject)
    {
        MeshRenderer meshRenderer = gameObject.GetComponent<MeshRenderer>();

        var request = assetBundle.LoadAllAssetsAsync<Shader>();

        while (!request.isDone)
        {
            yield return null;
        }

        Object[] objs = request.allAssets;

        for (int i = 0, length = objs.Length; i < length; ++i)
        {
            Shader shader = objs[i] as Shader;
            Assert.IsNotNull(shader);

            Material material = new Material(shader);

            meshRenderer.material = material;

            yield return null;

            Object.Destroy(material);
        }

        Object.Destroy(gameObject);
        promise.Resolve();
    }
}
