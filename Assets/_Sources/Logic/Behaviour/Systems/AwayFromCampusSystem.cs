using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class AwayFromCampusSystem : IExecuteSystem
{
    public const float Distance_Square = 5 * 5;

    private IGroup<GameEntity> _groups;

    public AwayFromCampusSystem(Contexts contexts)
    {
        _groups = contexts.game.GetGroup(GameMatcher.AllOf(GameMatcher.Position, GameMatcher.CampusPosition));
    }

    public void Execute()
    {
        foreach (var e in _groups)
        {
            e.isAwayFromCampus = IsAwayFromCampus(e);
        }
    }

    private bool IsAwayFromCampus(GameEntity e)
    {
        float diffX = e.position.x - e.campusPosition.x;
        float diffY = e.position.y - e.campusPosition.y;

        float distance = diffX * diffX + diffY * diffY;

        return distance > Distance_Square;
    }
}
