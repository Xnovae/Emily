using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class DestroyAssetSystem : ReactiveSystem<GameEntity>
{
    public DestroyAssetSystem(Contexts contexts)
        : base(contexts.game)
    {

    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Destroy.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasView;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            e.view.viewController.Destroy();
        }
    }
}
