using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

[Game]
public class PathFindingComponent : IComponent
{
    public CustomAIPath aiPath;
    public GameObject target;
}
