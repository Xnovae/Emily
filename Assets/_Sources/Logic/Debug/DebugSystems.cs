using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugSystems : Feature
{
    public DebugSystems(Contexts contexts)
        : base("Debug Systems")
    {
        Add(new UWADebugSystem(contexts));
    }
}
