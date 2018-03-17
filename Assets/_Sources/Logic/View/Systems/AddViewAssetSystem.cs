using System.Collections;
using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;
using UnityEngine.Assertions;

public class AddViewAssetSystem : ReactiveSystem<GameEntity>
{
    // private GameContext _gameContext;

    public AddViewAssetSystem(Contexts contexts) :
        base(contexts.game)
    {
        // _gameContext = contexts.game;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.ViewAsset);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasViewAsset && entity.hasView;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            Assert.IsNotNull(e.viewAsset.collectionData);

            var viewController = e.view.viewController;

            if (e.viewAsset.spriteName != null)
            {
                viewController.displaySprite.SetSprite(e.viewAsset.collectionData, e.viewAsset.spriteName);

                viewController.gameObject.SetActive(true);

                if (!e.isViewValid)
                {
                    e.isViewValid = true;
                }
            }

            viewController.gameObject.SetActive(true);
        }
    }
}
