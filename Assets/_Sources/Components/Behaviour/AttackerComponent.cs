using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

[Game]
public class AttackerComponent : IComponent
{
    public GameEntity attacker;
    public float damage;
}
