using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class DestroyCommonSystem : ReactiveSystem<GameEntity>
{
    public DestroyCommonSystem(Contexts contexts)
        : base(contexts.game)
    {
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Destroy.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.isEnabled;    // isEnabled is needed, cause it's a default handler
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            e.Destroy();
        }
    }
}
