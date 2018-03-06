using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;
using UnityEngine.Profiling;

public class PositionSystem : ReactiveSystem<GameEntity>
{
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
            Vector2 attempPos = e.attempPosition.value;

            Vector3 newPos = AstarPath.active.GetNearest(new Vector3(attempPos.x, attempPos.y, 0)).position;

            e.ReplacePosition(new Vector2(newPos.x, newPos.y));

            e.RemoveAttempPosition();
        }
    }
}
