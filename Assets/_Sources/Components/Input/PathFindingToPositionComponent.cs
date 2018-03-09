using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

[Input, Game]
public class PathFindingToPositionComponent : IComponent
{
    public GameEntity e;

    public float x;
    public float y;
}
