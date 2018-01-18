using System.Collections;
using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;

public class AddAssetSystem : ReactiveSystem<GameEntity>
{
    private GameContext _gameContext;

    private Transform _container;

    public AddAssetSystem(Contexts contexts) : 
        base(contexts.game)
    {
        _gameContext = contexts.game;

        _container = new GameObject("Game Views").transform;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Asset);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasAsset && entity.asset.viewController == null;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            GameObject prefab = _gameContext.runningData.ResourceData.spriteTemplate;

            GameObject gameObject = PoolManager.SpawnObject(prefab);
            gameObject.name = e.asset.name;

            gameObject.transform.SetParent(_container, false);
            gameObject.Link(e, _gameContext);

            var viewController = gameObject.GetComponent<ViewController>();
            e.asset.viewController = viewController;

            gameObject.SetActive(false);
        }
    }
}
