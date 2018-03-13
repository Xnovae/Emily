using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class ProcessInputActionSystem : ReactiveSystem<InputEntity>
{
    private readonly IGroup<GameEntity> _controllableEntities;
    private readonly IGroup<GameEntity> _monsters;

    public ProcessInputActionSystem(Contexts contexts)
        : base(contexts.input)
    {
        _controllableEntities =
            contexts.game.GetGroup(GameMatcher.AllOf(GameMatcher.Controllable, GameMatcher.StateMachine));

        _monsters = contexts.game.GetGroup(GameMatcher.Monster);
    }

    protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
    {
        return context.CreateCollector(InputMatcher.InputAction);
    }

    protected override bool Filter(InputEntity entity)
    {
        return entity.hasInputAction;
    }

    protected override void Execute(List<InputEntity> entities)
    {
        for (int i = 0, length = entities.Count; i < length; ++i)
        {
            var e = entities[i];
            var inputAction = e.inputAction;

            ProcessAction(inputAction.state);
        }
    }

    private void ProcessAction(CharacterState newState)
    {
        foreach (var e in _controllableEntities.GetEntities())
        {
            e.stateMachine.fsm.TriggerEvent("ResetToIdle");
            e.stateMachine.fsm.TriggerEvent(Consts.GetStateString(newState));

            // TODO refactor this!!!
            AttackMonster(e);
        }
    }

    private void AttackMonster(GameEntity attacker)
    {
        foreach (var e in _monsters)
        {
            if (IsAttackerWithinRange(e, attacker))
            {
                e.ReplaceAttacker(attacker, 10.0f);
            }
        }
    }

    private bool IsAttackerWithinRange(GameEntity target, GameEntity attacker)
    {
        float diffX = attacker.position.x - target.position.x;
        float diffY = attacker.position.y - target.position.y;

        return (diffX * diffX + diffY * diffY) <= target.monsterParameter.alarmRange;
    }
}
