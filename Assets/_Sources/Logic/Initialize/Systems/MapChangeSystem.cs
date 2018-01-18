using System.Collections;
using System.Collections.Generic;
using System.IO;
using ClientConfig;
using Entitas;
using UnityEngine;
using UnityEngine.Assertions;

public class MapChangeSystem : IInitializeSystem
{
    public const string MAP_ASSET_NAME = "map";

    private GameContext _gameContext;

    public MapChangeSystem(Contexts contexts) 
    {
        _gameContext = contexts.game;
    }

    public void Initialize()
    {
        _gameContext.GetGroup(GameMatcher.Map).OnEntityAdded += (group, entity, index, component) =>
        {
            // 新加载地图
            MapComponent map = component as MapComponent;

            AddMap(map);
        };

        _gameContext.GetGroup(GameMatcher.Map).OnEntityUpdated += (group, entity, index, component, newComponent) =>
        {
            // 对比清理
            MapComponent oldMap = component as MapComponent;
            MapComponent newMap = newComponent as MapComponent;
            
            CleanAndAddMap(oldMap, newMap);
        };
    }

    private void AddMap(MapComponent map)
    {
        Assert.IsNotNull(map);

        MapItem mapItem = ConfigManager.Instance.GetItem<Map, MapItem>(MAP_ASSET_NAME, map.id);

        string name = mapItem.name;
        int width = mapItem.width;
        int height = mapItem.height;
        string pathFormat = Utils.GetBundlePathForLoadFromFile(mapItem.pathFormat);

        _gameContext.runningData.RuntimeData.mapName = name;
        _gameContext.runningData.RuntimeData.mapWidth = width;
        _gameContext.runningData.RuntimeData.mapHeight = height;
        _gameContext.runningData.RuntimeData.mapPathFormat = pathFormat;

        // CameraMapSystem 加载视野范围内所有的地图块, 设置 isMapLoad
    }

    private void CleanAndAddMap(MapComponent oldMap, MapComponent newMap)
    {
        Assert.IsNotNull(oldMap);
        Assert.IsNotNull(newMap);

        // clear map in CameraMapSystem
        AddMap(newMap);
    }
}
