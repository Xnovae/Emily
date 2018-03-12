using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class AwayFromCampusSystem : IExecuteSystem
{
    private IGroup<GameEntity> _groups;

    public AwayFromCampusSystem(Contexts contexts)
    {
        _groups = contexts.game.GetGroup(GameMatcher.AllOf(GameMatcher.Position, GameMatcher.CampusPosition, GameMatcher.MonsterParameter));
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

        return distance > e.monsterParameter.campusRange;
    }
}
