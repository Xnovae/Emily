using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class TagSystem : ReactiveSystem<GameEntity>
{
    public TagSystem(Contexts contexts)
        : base(contexts.game)
    {
        
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Tag);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasView && entity.hasTag;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            e.view.viewController.gameObject.tag = e.tag.tag;
        }
    }
}
