using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class PathFindingStopSystem : ReactiveSystem<GameEntity>
{
    public PathFindingStopSystem(Contexts contexts)
        : base(contexts.game)
    {
        
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.AIMoving.Removed());
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            if (e.hasPathFinding)
            {
                PoolManager.Instance.ReleaseObject(e.pathFinding.aiPath.gameObject);
                PoolManager.Instance.ReleaseObject(e.pathFinding.target);

                e.RemovePathFinding();
            }
            else
            {
                // do nothing
            }
        }
    }
}
