using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySystems : Feature
{
    public DestroySystems(Contexts contexts)
        : base("Destroy System")
    {
        Add(new DestroyAssetSystem(contexts));
        Add(new DestroyResourceAssetBundleSystem(contexts));
        Add(new DestroyCommonSystem(contexts));
    }
}
