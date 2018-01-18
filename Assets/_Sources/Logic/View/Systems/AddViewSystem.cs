using System.Collections;
using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;
using UnityEngine.Assertions;

public class AddViewSystem : ReactiveSystem<GameEntity>
{
    // private GameContext _gameContext;

    public AddViewSystem(Contexts contexts) :
        base(contexts.game)
    {
        // _gameContext = contexts.game;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.View);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasView && entity.hasAsset;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            var viewController = e.asset.viewController;
            viewController.tk2dSprite.SetSprite(e.view.collectionData, e.view.spriteName);

            viewController.gameObject.SetActive(true);

            Assert.IsNotNull(viewController.tk2dSprite.Collection);
            Assert.AreEqual(true, viewController.tk2dSprite.Collection);
        }
    }
}
