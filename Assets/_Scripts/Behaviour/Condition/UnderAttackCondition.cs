using System.Collections;
using System.Collections.Generic;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;

[TaskCategory("Custom")]
public class UnderAttackCondition : Conditional
{
    public SharedGameEntity selfEntity;

    public override TaskStatus OnUpdate()
    {
        if (selfEntity.Value.hasAttacker)
        {
            return TaskStatus.Success;
        }
        else
        {
            return TaskStatus.Failure;
        }
    }
}
