using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class StateViewSystem : ReactiveSystem<GameEntity>
{
    public StateViewSystem(Contexts contexts)
        : base(contexts.game)
    {
        
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.State);
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            
        }
    }
}
