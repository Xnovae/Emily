using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeSystems : Feature
{
    public InitializeSystems(Contexts contexts)
        : base("Initialize System")
    {
        Add(new InitSystem(contexts));
        Add(new ResourceSystem(contexts));
        Add(new MapChangeSystem(contexts));
        Add(new CameraMapSystem(contexts));

        Add(new CreatePlayerSystem(contexts));
    }
}
