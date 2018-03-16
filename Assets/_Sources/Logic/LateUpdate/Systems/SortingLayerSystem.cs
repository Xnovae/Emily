using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class SortingLayerSystem : ReactiveSystem<GameEntity>
{
    public SortingLayerSystem(Contexts contexts)
        : base(contexts.game)
    { }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.AllOf(GameMatcher.ViewValid, GameMatcher.SortingLayer));
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasView;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            string sortingLayerName = e.sortingLayer.value;
            if (e.view.viewController.displayRenderer.sortingLayerName != sortingLayerName)
            {
                e.view.viewController.displayRenderer.sortingLayerName = sortingLayerName;
            }
        }
    }
}
