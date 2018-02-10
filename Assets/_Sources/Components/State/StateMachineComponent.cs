using System.Collections;
using System.Collections.Generic;
using Entitas;
using RSG;
using UnityEngine;

[Game]
public class StateMachineComponent : IComponent
{
    public string state;
    public IState fsm;
}
