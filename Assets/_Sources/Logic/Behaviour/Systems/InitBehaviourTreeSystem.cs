using System.Collections;
using System.Collections.Generic;
using BehaviorDesigner.Runtime;
using Entitas;
using UnityEngine;
using UnityEngine.Assertions;

public class InitBehaviourTreeSystem : ReactiveSystem<GameEntity>
{
    public InitBehaviourTreeSystem(Contexts contexts)
        : base(contexts.game)
    {
        
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.AllOf(GameMatcher.BehaviourTree, GameMatcher.View));
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasBehaviourTree && entity.behaviourTree.behaviorTree == null && entity.hasView;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            string name = e.behaviourTree.behaviorTreeName;
            ExternalBehavior externalBehavior = Resources.Load<ExternalBehavior>(name);
            Assert.IsNotNull(externalBehavior);

            ExternalBehavior instance = Object.Instantiate(externalBehavior);
            instance.Init();

            BehaviorTree behaviorTree = e.view.viewController.gameObject.GetComponent<BehaviorTree>();
            Assert.IsNotNull(behaviorTree);

            behaviorTree.ExternalBehavior = instance;
            behaviorTree.SetVariable("SelfGameEntity", (SharedGameEntity)e);

            behaviorTree.EnableBehavior();
        }
    }

}
