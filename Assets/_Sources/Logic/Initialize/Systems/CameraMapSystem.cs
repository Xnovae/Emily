using System.Collections;
using System.Collections.Generic;
using Codes.Linus.IntVectors;
using Entitas;
using RSG;
using UnityEngine;
using UnityEngine.Assertions;

public class CameraMapSystem : IInitializeSystem, IExecuteSystem
{
    public const int MAP_ITEM_WIDTH = 512;
    public const int MAP_ITEM_HEIGHT = 512;

    public const int TexturePixelsPerUnit = 100;

    private GameContext _gameContext;

    private Camera _camera;
    private Transform _cameraTransform;
    private CameraLoadingBounds _cameraLoadingBounds;

    private float _mapItemWidth;
    private float _mapItemHeight;

    private int _mapWidthCount;
    private int _mapHeightCount;

    // private Transform _mapParentTransform;

    private Dictionary<Vector2i, GameEntity> _mapItemDictionary = new Dictionary<Vector2i, GameEntity>();
    private List<Vector2i> _removalList = new List<Vector2i>(64);

    public CameraMapSystem(Contexts contexts)
    {
        _gameContext = contexts.game;
    }

    public void Initialize()
    {
        _camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

        _cameraTransform = _camera.transform;
        // _mapParentTransform = new GameObject("Maps").transform;
        _cameraLoadingBounds = _camera.GetComponent<CameraLoadingBounds>();

        _mapItemWidth = (float)MAP_ITEM_WIDTH / TexturePixelsPerUnit;
        _mapItemHeight = (float)MAP_ITEM_WIDTH / TexturePixelsPerUnit;

        _gameContext.GetGroup(GameMatcher.Map).OnEntityAdded += (group, entity, index, component) =>
        {
            LoadFirstViewMapBlock();
        };

        _gameContext.GetGroup(GameMatcher.Map).OnEntityUpdated += (group, entity, index, component, newComponent) =>
        {
            // 对比清理
            MapComponent oldMap = component as MapComponent;
            MapComponent newMap = newComponent as MapComponent;

            CleanAndAddMap(oldMap, newMap);
        };
    }

    private void CleanAndAddMap(MapComponent oldMap, MapComponent newMap)
    {
        Assert.IsNotNull(oldMap);
        Assert.IsNotNull(newMap);

        // clearup old map
        var enumerator = _mapItemDictionary.GetEnumerator();
        while (enumerator.MoveNext())
        {
            var current = enumerator.Current;

            GameEntity e = current.Value;
            e.Release(this);

            e.isDestroy = true;
        }
        enumerator.Dispose();

        // load new map
        LoadFirstViewMapBlock();
    }

    private void LoadFirstViewMapBlock()
    {
        _gameContext.isMapLoad = false;
        _mapItemDictionary.Clear();

        _mapWidthCount = Mathf.CeilToInt((float)_gameContext.runningData.RuntimeData.mapWidth / MAP_ITEM_WIDTH);
        _mapHeightCount = Mathf.CeilToInt((float)_gameContext.runningData.RuntimeData.mapHeight / MAP_ITEM_HEIGHT);

        Vector4 viewBounds = GetViewBounds(_cameraTransform);

        int xMin = Mathf.Max(0, Mathf.FloorToInt(viewBounds.x / _mapItemWidth));
        int xMax = Mathf.Min(_mapWidthCount, Mathf.CeilToInt((viewBounds.x + viewBounds.z) / _mapItemWidth));

        int yMin = Mathf.Max(0, Mathf.FloorToInt(viewBounds.y / _mapItemHeight));
        int yMax = Mathf.Min(_mapHeightCount, Mathf.CeilToInt((viewBounds.y + viewBounds.w) / _mapItemHeight));

        int length = (xMax - xMin) * (yMax - yMin);
        length = Mathf.Max(0, length);
        IPromise[] promises = new IPromise[length];

        int index = 0;
        for (int x = xMin; x < xMax; ++x)
        {
            for (int y = yMin; y < yMax; ++y)
            {
                promises[index] = LoadViewMapItem(x, y);
                ++index;
            }
        }

        Promise.All(promises)
            .Catch(ex => Debug.LogException(ex))
            .Done(() => { _gameContext.isMapLoad = true; });
    }

    private IPromise LoadViewMapItem(int x, int y)
    {
        var promise = new Promise();

        Vector2i key = new Vector2i(x, y);

        GameEntity e = _gameContext.CreateEntity();
        e.Retain(this);
        _mapItemDictionary.Add(key, e);

        string path = string.Format(_gameContext.runningData.RuntimeData.mapPathFormat, x.ToString(), y.ToString());
        string assetName = x.ToString() + "_" + y.ToString();

        e.AddView(null, assetName);
        e.AddPosition(new Vector2((float)x * MAP_ITEM_WIDTH / TexturePixelsPerUnit, (float)y * MAP_ITEM_HEIGHT / TexturePixelsPerUnit));
        e.AddResourceAssetBundle(path, this);

        ResourceManager.Instance.GetAssetBundleAsset(path, assetName, this)
            .Then(asset =>
            {
                var gameObject = asset as GameObject;
                Assert.IsNotNull(gameObject);
                var collectionData = gameObject.GetComponent<tk2dSpriteCollectionData>();

                // e.AddViewAsset(collectionData, assetName);
                _mapItemDictionary[key].AddViewAsset(collectionData, assetName);

                int count = ResourceManager.Instance.GetAssetBundleWrappersCount(path);
                Assert.AreEqual(1, count, "load map path: " + path);

                promise.Resolve();
            })
            .Catch(ex => { promise.Reject(ex); });

        return promise;
    }

    public void Execute()
    {
        if (_gameContext.isMapLoad == false)
        {
            // camera map is not ready
            return;
        }

        UnLoadMap();
        LoadMap();
    }

    private void UnLoadMap()
    {
        _removalList.Clear();

        var enumerator = _mapItemDictionary.GetEnumerator();
        while (enumerator.MoveNext())
        {
            var current = enumerator.Current;

            if (!IsInsideLoadingBounds(current.Key))
            {
                _removalList.Add(current.Key);
            }
        }
        enumerator.Dispose();

        for (int i = 0, length = _removalList.Count; i < length; ++i)
        {
            Vector2i key = _removalList[i];
            GameEntity e = _mapItemDictionary[key];
            _mapItemDictionary.Remove(key);
            e.Release(this);

            e.isDestroy = true;

            string path = string.Format(_gameContext.runningData.RuntimeData.mapPathFormat, key.x.ToString(), key.y.ToString());
            int count = ResourceManager.Instance.GetAssetBundleWrappersCount(path);
            Assert.AreEqual(1, count, "unload map: " + path);
        }
    }

    private bool IsInsideLoadingBounds(Vector2i position)
    {
        Vector4 loadingBounds = GetLoadingBounds(_cameraTransform);

        int xMin = Mathf.Max(0, Mathf.FloorToInt(loadingBounds.x / _mapItemWidth));
        int xMax = Mathf.Min(_mapWidthCount, Mathf.CeilToInt((loadingBounds.x + loadingBounds.z) / _mapItemWidth));

        int yMin = Mathf.Max(0, Mathf.FloorToInt(loadingBounds.y / _mapItemHeight));
        int yMax = Mathf.Min(_mapHeightCount, Mathf.CeilToInt((loadingBounds.y + loadingBounds.w) / _mapItemHeight));

        return (xMin <= position.x && position.x < xMax) && (yMin <= position.y && position.y < yMax);
    }

    private void LoadMap()
    {
        Vector4 loadingBounds = GetLoadingBounds(_cameraTransform);

        int xMin = Mathf.Max(0, Mathf.FloorToInt(loadingBounds.x / _mapItemWidth));
        int xMax = Mathf.Min(_mapWidthCount, Mathf.CeilToInt((loadingBounds.x + loadingBounds.z) / _mapItemWidth));

        int yMin = Mathf.Max(0, Mathf.FloorToInt(loadingBounds.y / _mapItemHeight));
        int yMax = Mathf.Min(_mapHeightCount, Mathf.CeilToInt((loadingBounds.y + loadingBounds.w) / _mapItemHeight));

        for (int x = xMin; x < xMax; ++x)
        {
            for (int y = yMin; y < yMax; ++y)
            {
                LoadMapItem(x, y);
            }
        }
    }

    private Vector4 GetLoadingBounds(Transform cameraTransform)
    {
        Vector3 position = cameraTransform.position;
        Vector4 cameraLoadingOffset = _cameraLoadingBounds.LoadingOffset;

        Vector4 cameraBounds = new Vector4();

        float cameraHeightSize = _camera.orthographicSize;
        float cameraWidthSize = _camera.aspect * cameraHeightSize;

        cameraBounds.x = position.x - cameraWidthSize;
        cameraBounds.y = position.y - cameraHeightSize;
        cameraBounds.z = 2 * cameraWidthSize;      // width
        cameraBounds.w = 2 * cameraHeightSize;     // height

        cameraBounds.x -= cameraLoadingOffset.w >= 0.0f ? cameraLoadingOffset.w : 0.0f;
        cameraBounds.y -= cameraLoadingOffset.x >= 0.0f ? cameraLoadingOffset.x : 0.0f;
        cameraBounds.z += (cameraLoadingOffset.w >= 0.0f ? cameraLoadingOffset.w : 0.0f) + (cameraLoadingOffset.y >= 0.0f ? cameraLoadingOffset.y : 0.0f);
        cameraBounds.w += (cameraLoadingOffset.x >= 0.0f ? cameraLoadingOffset.x : 0.0f) + (cameraLoadingOffset.z >= 0.0f ? cameraLoadingOffset.z : 0.0f);

        return cameraBounds;
    }

    private Vector4 GetViewBounds(Transform cameraTransform)
    {
        Vector3 position = cameraTransform.position;

        Vector4 cameraBounds = new Vector4();

        float cameraHeightSize = _camera.orthographicSize;
        float cameraWidthSize = _camera.aspect * cameraHeightSize;

        cameraBounds.x = position.x - cameraWidthSize;
        cameraBounds.y = position.y - cameraHeightSize;
        cameraBounds.z = 2 * cameraWidthSize;      // width
        cameraBounds.w = 2 * cameraHeightSize;     // height

        return cameraBounds;
    }

    private void LoadMapItem(int x, int y)
    {
        Vector2i key = new Vector2i(x, y);
        GameEntity e;

        if (_mapItemDictionary.TryGetValue(key, out e))
        {
            return;
        }
        else
        {
            LoadMapItemInternal(x, y, key);
        }
    }

    // Tips:: Not execute method should be extracted to avoid lamdba memory allocation
    private void LoadMapItemInternal(int x, int y, Vector2i key)
    {
        GameEntity e;
        e = _gameContext.CreateEntity();
        e.Retain(this);
        _mapItemDictionary.Add(key, e);

        string path = string.Format(_gameContext.runningData.RuntimeData.mapPathFormat, x.ToString(), y.ToString());
        string assetName = x.ToString() + "_" + y.ToString();

        e.AddView(null, assetName);
        e.AddPosition(new Vector2((float) x * MAP_ITEM_WIDTH / TexturePixelsPerUnit,
            (float) y * MAP_ITEM_HEIGHT / TexturePixelsPerUnit));
        e.AddResourceAssetBundle(path, this);

        ResourceManager.Instance.GetAssetBundleAsset(path, assetName, this)
            .Then(asset =>
            {
                var gameObject = asset as GameObject;
                Assert.IsNotNull(gameObject);
                var collectionData = gameObject.GetComponent<tk2dSpriteCollectionData>();

                // e.AddViewAsset(collectionData, assetName);    // CAUTION: DON'T use e, cause view and Asset not same
                _mapItemDictionary[key].AddViewAsset(collectionData, assetName);

                int count = ResourceManager.Instance.GetAssetBundleWrappersCount(path);
                Assert.AreEqual(1, count, "load map path: " + path + ", count: " + count);
            });
    }
}
