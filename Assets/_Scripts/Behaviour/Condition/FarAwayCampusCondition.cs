using System.Collections;
using System.Collections.Generic;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;
using UnityEngine.Assertions;

[TaskCategory("Custom")]
public class FarAwayCampusCondition : Conditional
{
    public SharedGameEntity selfEntity;

    public override TaskStatus OnUpdate()
    {
        if (selfEntity.Value.isAwayFromCampus)
        {
            return TaskStatus.Success;
        }
        else
        {
            return TaskStatus.Failure;
        }
    }
}
