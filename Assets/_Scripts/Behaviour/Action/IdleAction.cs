using System.Collections;
using System.Collections.Generic;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;

[TaskCategory("Custom")]
public class IdleAction : Action
{
    public SharedGameEntity gameEntity;

    public override TaskStatus OnUpdate()
    {
        GameEntity e = gameEntity.Value;
        if (e.state.state != CharacterState.Idle)
        {
            e.stateMachine.fsm.TriggerEvent("ResetToIdle");
            e.stateMachine.fsm.TriggerEvent(CharacterState.Idle.ToString());
        }

        return TaskStatus.Success;
    }
}
