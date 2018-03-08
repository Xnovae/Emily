using System.Collections;
using System.Collections.Generic;
using Entitas;
using Pathfinding;
using UnityEngine;
using UnityEngine.Profiling;

public class PositionSystem : ReactiveSystem<GameEntity>
{
    private static NNConstraint walkableArea = NNConstraint.Default;

    public PositionSystem(Contexts contexts)
        : base(contexts.game)
    {
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.AttempPosition.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasPosition;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            var position = new Vector3(e.attempPosition.x, e.attempPosition.y, 0);

            Vector3 newPos = AstarPath.active.GetNearest(position, walkableArea).position;

            e.ReplacePosition(newPos.x, newPos.y);

            e.RemoveAttempPosition();
        }
    }
}
