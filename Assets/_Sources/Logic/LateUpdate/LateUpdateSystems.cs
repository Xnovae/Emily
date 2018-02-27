using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateUpdateSystems : Feature
{
    public LateUpdateSystems(Contexts contexts)
        : base("LateUpdate Systems")
    {
        Add(new CameraFollowSystem(contexts));
    }
}
