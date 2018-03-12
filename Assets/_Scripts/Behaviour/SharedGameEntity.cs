using System.Collections;
using System.Collections.Generic;
using BehaviorDesigner.Runtime;
using UnityEngine;

[System.Serializable]
public class SharedGameEntity : SharedVariable<GameEntity>
{
    public static implicit operator SharedGameEntity(GameEntity value)
    {
        return new SharedGameEntity { Value = value };
    }
}
