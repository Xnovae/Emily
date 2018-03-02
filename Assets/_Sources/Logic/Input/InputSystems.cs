using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystems : Feature
{
    public InputSystems(Contexts contexts)
        : base("Input Systems")
    {
        Add(new EmitInputSystem(contexts));
        Add(new ProcessInputMoveSystem(contexts));
        Add(new ProcessInputActionSystem(contexts));
        Add(new ProcessInputMoveToPositionSystem(contexts));
    }
}
