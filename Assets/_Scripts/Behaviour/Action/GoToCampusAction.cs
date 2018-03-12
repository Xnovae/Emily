using System.Collections;
using System.Collections.Generic;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;

[TaskCategory("Custom")]
public class GoToCampusAction : Action
{
    public SharedGameEntity gameEntity;

    public override void OnStart()
    {
        GameEntity e = gameEntity.Value;

        float campusX = e.campusPosition.x;
        float campusY = e.campusPosition.y;

        e.ReplacePathFindingToPosition(campusX, campusY);
    }

    public override TaskStatus OnUpdate()
    {
        GameEntity e = gameEntity.Value;

        if (e.isAIMoving)
        {
            return TaskStatus.Running;
        }
        else
        {
            if (e.hasAttacker)
            {
                e.RemoveAttacker();
            }

            return TaskStatus.Success;
        }
    }
}
