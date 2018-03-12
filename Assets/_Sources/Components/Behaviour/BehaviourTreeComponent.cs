using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;
using BehaviorDesigner.Runtime;

[Game]
public class BehaviourTreeComponent : IComponent
{
    public BehaviorTree behaviorTree;
    public string behaviorTreeName;
}
