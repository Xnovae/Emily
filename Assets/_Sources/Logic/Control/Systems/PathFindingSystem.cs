using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class PathFindingSystem : IExecuteSystem
{
    private IGroup<GameEntity> _pathFindingGroup;

    public PathFindingSystem(Contexts contexts)
    {
        _pathFindingGroup = contexts.game.GetGroup(GameMatcher.AllOf(GameMatcher.PathFinding, GameMatcher.Position, GameMatcher.Direction, GameMatcher.StateMachine));
    }

    public void Execute()
    {
        foreach (var e in _pathFindingGroup.GetEntities())
        {
            bool isMoving = e.pathFinding.aiPath.IsMoving;
            if (isMoving)
            {
                e.isAIMoving = true;

                // trigger Run
                e.stateMachine.fsm.TriggerEvent(Consts.STRING_FSM_RUN);

                // position
                ProcessPosition(e);

                // direction
                ProcessDirection(e);
            }
            else
            {
                // path finding finished
                e.isAIMoving = false;
            }
        }
    }

    private void ProcessDirection(GameEntity e)
    {
        Vector2 velocity = e.pathFinding.aiPath.CurrentVelocity;
        CharacterDirection newDirection = Utils.GetCharacterDirection(velocity.x, velocity.y);
        if (newDirection != CharacterDirection.None)
        {
            CharacterDirection oldDirection = e.direction.direction;

            if (newDirection != oldDirection)
            {
                e.ReplaceDirection(newDirection);
            }
        }
    }

    private void ProcessPosition(GameEntity e)
    {
        Vector3 position = e.pathFinding.aiPath.CurrentPosition;
        e.ReplacePosition(position.x, position.y);
    }
}
