using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSystems : Feature
{
    public ControlSystems(Contexts contexts)
        : base("Control Systems")
    {
        Add(new VelocitySystem(contexts));
        Add(new PositionSystem(contexts));
        Add(new StateMachineSystem(contexts));
        Add(new UpdateStateMachineSystem(contexts));
        Add(new PathFindingSystem(contexts));
    }
}
