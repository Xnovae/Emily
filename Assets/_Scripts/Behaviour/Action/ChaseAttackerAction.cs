using System.Collections;
using System.Collections.Generic;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;

[TaskCategory("Custom")]
public class ChaseAttackerAction : Action
{
    public const float Attack_Range = 0.2f * 0.2f;

    public SharedGameEntity gameEntity;

    public override TaskStatus OnUpdate()
    {
        GameEntity victom = gameEntity.Value;
        GameEntity attacker = victom.attacker.attacker;

        if (IsWithinAttackRange(victom, attacker))
        {
            // within attack range wait for quit
        }
        else
        {
            // navigate to attacker
            float attackerX = attacker.position.x;
            float attackerY = attacker.position.y;

            victom.ReplacePathFindingToPosition(attackerX, attackerY);
            victom.isAIMoving = true;
        }

        if (victom.isAIMoving)
        {
            return TaskStatus.Running;
        }
        else
        {
            return TaskStatus.Success;
        }
    }

    private bool IsWithinAttackRange(GameEntity victom, GameEntity attacker)
    {
        float diffX = attacker.position.x - victom.position.x;
        float diffY = attacker.position.y - victom.position.y;

        return (diffX * diffX + diffY * diffY) <= Attack_Range;
    }
}
