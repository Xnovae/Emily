using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TearDownSystems : Feature
{
    public TearDownSystems(Contexts contexts)
        : base("TearDown Systems")
    {
        Add(new TearDownConfigManagerSystem());
    }
}
