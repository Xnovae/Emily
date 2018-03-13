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
            .Then(() => InitializeSpritePoolManager())    // 生成 tk2d template
            .Then(spriteTemplate =>
            {
                _gameContext.runningData.ResourceData.spriteTemplate = spriteTemplate;

                return InitializeCharacterPoolManager();    // 加载角色
            })
            .Then(characterTemplate =>
            {
                _gameContext.runningData.ResourceData.characterTemplate = characterTemplate;

                return InitializeMonsterPoolManager();      // 加载怪物
            })
            .Then(monsterTemplate =>
            {
                _gameContext.runningData.ResourceData.monsterTemplate = monsterTemplate;

                return InitializeSeekerPoolManager();   // 加载寻路 Seeker
            })
            .Then(seekerTemplate =>
            {
                _gameContext.runningData.ResourceData.pathFindingSeekerTempldate = seekerTemplate;

                return InitializeTargetPoolManager();    // 加载寻路 Target
            })
            .Then(targetTemplate =>
            {
                _gameContext.runningData.ResourceData.pathFindingTargetTempldate = targetTemplate;

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

    private IPromise<GameObject> InitializeSpritePoolManager()
    {
        var promise = new Promise<GameObject>();

        ResourceManager.Instance.GetResourceAsset<GameObject>(Consts.Template_Tk2dSprite, this)
            .Then(spriteTemplate =>
            {
                PoolManager.Instance.WarmPool(spriteTemplate, 50);
                promise.Resolve(spriteTemplate);
            })
            .Catch(ex =>
            {
                promise.Reject(new Exception("Fail to load Template_Tk2dSprite ex: " + ex));
            });

        return promise;
    }

    private IPromise<GameObject> InitializeCharacterPoolManager()
    {
        var promise = new Promise<GameObject>();

        ResourceManager.Instance.GetResourceAsset<GameObject>(Consts.Template_Character, this)
            .Then(spriteTemplate =>
            {
                PoolManager.Instance.WarmPool(spriteTemplate, 50);
                promise.Resolve(spriteTemplate);
            })
            .Catch(ex =>
            {
                promise.Reject(new Exception("Fail to load Template_Character ex: " + ex));
            });

        return promise;
    }

    private IPromise<GameObject> InitializeMonsterPoolManager()
    {
        var promise = new Promise<GameObject>();

        ResourceManager.Instance.GetResourceAsset<GameObject>(Consts.Template_Monster, this)
            .Then(spriteTemplate =>
            {
                PoolManager.Instance.WarmPool(spriteTemplate, 50);
                promise.Resolve(spriteTemplate);
            })
            .Catch(ex =>
            {
                promise.Reject(new Exception("Fail to load Template_Monster ex: " + ex));
            });

        return promise;
    }

    private IPromise<GameObject> InitializeSeekerPoolManager()
    {
        var promise = new Promise<GameObject>();

        ResourceManager.Instance.GetResourceAsset<GameObject>(Consts.Template_PathFinding_Seeker, this)
            .Then(gameObjectTemplate =>
            {
                PoolManager.Instance.WarmPool(gameObjectTemplate, 200);
                promise.Resolve(gameObjectTemplate);
            })
            .Catch(ex =>
            {
                promise.Reject(new Exception("Fail to load Template_PathFinding_Seeker ex: " + ex));
            });

        return promise;
    }

    private IPromise<GameObject> InitializeTargetPoolManager()
    {
        var promise = new Promise<GameObject>();

        ResourceManager.Instance.GetResourceAsset<GameObject>(Consts.Template_PathFinding_Target, this)
            .Then(gameObjectTemplate =>
            {
                PoolManager.Instance.WarmPool(gameObjectTemplate, 200);
                promise.Resolve(gameObjectTemplate);
            })
            .Catch(ex =>
            {
                promise.Reject(new Exception("Fail to load Template_PathFinding_Target ex: " + ex));
            });

        return promise;
    }

    private IPromise InitializeAssetBundleManifest()
    {
        var promise = new Promise();

        var manifestPath = Utils.GetBundlePathForLoadFromFile("AssetBundleManifest");

        ResourceManager.Instance.InitAssetBundleManifest(manifestPath, this)
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
#if !UNITY_EDITOR && UNITY_ANDROID
        string destPath = Application.persistentDataPath + "/config.cdb";

        if (File.Exists(destPath))
        {
            promise.Resolve(destPath);
        }
        else
        {
            MainThreadDispatcher.StartUpdateMicroCoroutine(CopyConfigFiles(promise, sourcePath, destPath));
        }
#else
        promise.Resolve(sourcePath);
#endif

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

        ResourceManager.Instance.GetAssetBundle(shadersAssetBundle, true, this)
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
