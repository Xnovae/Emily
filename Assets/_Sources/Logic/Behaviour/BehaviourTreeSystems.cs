using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourTreeSystems : Feature
{
    public BehaviourTreeSystems(Contexts contexts)
        : base("BehaviourTree Systems")
    {
        Add(new InitBehaviourTreeSystem(contexts));
        Add(new AwayFromCampusSystem(contexts));
        Add(new AlarmAttackSystem(contexts));
    }
}
