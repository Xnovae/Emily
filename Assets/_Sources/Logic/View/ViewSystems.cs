using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewSystems : Feature
{
    public ViewSystems(Contexts contexts)
        : base("View Systems")
    {
        Add(new AddViewSystem(contexts));
        Add(new AddViewAssetSystem(contexts));
        Add(new RenderPositionSystem(contexts));
        Add(new DirectionViewSystem(contexts));
        Add(new StateViewSystem(contexts));
        Add(new SpriteAnimateSystem(contexts));
        Add(new TagSystem(contexts));
    }
}
