using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Entitas;
using UnityEngine;

public class DestroyTweenSystem : ReactiveSystem<GameEntity>
{
    public DestroyTweenSystem(Contexts contexts)
        : base(contexts.game)
    {
        
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Tween.Removed());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasTweenResult;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            e.tweenResult.tweener.Kill();

            e.RemoveTweenResult();
        }

    }
}
