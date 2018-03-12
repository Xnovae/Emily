using System.Collections;
using System.Collections.Generic;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;

[TaskCategory("Custom")]
public class AttackAction : Action
{
    public SharedGameEntity gameEntity;

    private CharacterState _attackState;

    private static CharacterState[] AttackStates = new CharacterState[4];

    static AttackAction()
    {
        AttackStates[0] = CharacterState.LightAttack1;
        AttackStates[1] = CharacterState.LightAttack2;
        AttackStates[2] = CharacterState.HeavyAttack1;
        AttackStates[3] = CharacterState.HeavyAttack2;
    }

    public override void OnStart()
    {
        InitAttackState();

        GameEntity e = gameEntity.Value;

        e.stateMachine.fsm.TriggerEvent("ResetToIdle");
        e.stateMachine.fsm.TriggerEvent(Consts.GetStateString(_attackState));
    }

    private void InitAttackState()
    {
        int index = Random.Range(0, 4);
        _attackState = AttackStates[index];
    }

    public override TaskStatus OnUpdate()
    {
        GameEntity e = gameEntity.Value;

        if (e.state.state != _attackState)
        {
            return TaskStatus.Success;
        }
        else
        {
            return TaskStatus.Running;
        }
    }
}
