using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenSystems : Feature
{
    public TweenSystems(Contexts contexts)
        : base("Tween Systems")
    {
        Add(new EmitTweenSystem(contexts));
        Add(new DestroyTweenSystem(contexts));
    }
}
