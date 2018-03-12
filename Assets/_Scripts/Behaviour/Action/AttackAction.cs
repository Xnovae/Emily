using System.Collections;
using System.Collections.Generic;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;

[TaskCategory("Custom")]
public class AttackAction : Action
{
    public SharedGameEntity gameEntity;

    public override void OnStart()
    {
        GameEntity e = gameEntity.Value;

        e.stateMachine.fsm.TriggerEvent("ResetToIdle");
        e.stateMachine.fsm.TriggerEvent(Consts.StateStringCache[CharacterState.LightAttack1]);
    }

    public override TaskStatus OnUpdate()
    {
        GameEntity e = gameEntity.Value;

        if (e.state.state == CharacterState.HeavyAttack1)
        {
            return TaskStatus.Running;
        }
        else
        {
            return TaskStatus.Success;
        }
    }
}
