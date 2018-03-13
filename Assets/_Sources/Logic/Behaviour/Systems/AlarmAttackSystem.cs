using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class AlarmAttackSystem : ReactiveSystem<GameEntity>
{
    private IGroup<GameEntity> _monsters;

    public AlarmAttackSystem(Contexts contexts)
        : base(contexts.game)
    {
        _monsters = contexts.game.GetGroup(GameMatcher.AllOf(GameMatcher.Monster, GameMatcher.Position));
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.AllOf(GameMatcher.Controllable, GameMatcher.Position));
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.isControllable && entity.hasPosition;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            AlarmMonsters(e);
        }
    }

    private void AlarmMonsters(GameEntity entity)
    {
        foreach (var monster in _monsters)
        {
            if (IsWithinAlarmRange(monster, entity))
            {
                monster.ReplaceAttacker(entity, 0.0f);
            }
        }
    }

    private bool IsWithinAlarmRange(GameEntity target, GameEntity attacker)
    {
        float diffX = attacker.position.x - target.position.x;
        float diffY = attacker.position.y - target.position.y;

        return (diffX * diffX + diffY * diffY) <= target.monsterParameter.alarmRange;
    }
}
