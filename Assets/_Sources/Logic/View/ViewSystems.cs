using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewSystems : Feature
{
    public ViewSystems(Contexts contexts)
        : base("View Systems")
    {
        Add(new AddAssetSystem(contexts));
        Add(new AddViewSystem(contexts));
        Add(new RenderPositionSystem(contexts));
    }
}
