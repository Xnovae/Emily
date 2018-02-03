using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Entitas;
using UnityEngine;

public class EmitTweenSystem : ReactiveSystem<GameEntity>
{
    public EmitTweenSystem(Contexts contexts)
        : base(contexts.game)
    {
        
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Tween.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            if (!e.hasTweenResult)
            {
                AddTweenResult(e);
            }
            else
            {
                ReplaceTweenResult(e);
            }
        }
    }

    private void ReplaceTweenResult(GameEntity e)
    {
        Tweener tweener = e.tweenResult.tweener;

        float startValue = e.tween.startValue;
        float endValue = e.tween.endValue - Consts.Epsilon_Float;
        float duration = e.tween.duration;

        bool repeat = e.tween.repeat;

        float oldTweenValue = tweener.fullPosition;

        tweener.ChangeValues(startValue, endValue, duration).SetLoops(repeat ? -1 : 1);
        tweener.fullPosition = e.isTweenResultPreserved ? oldTweenValue : 0.0f;
    }

    private void AddTweenResult(GameEntity e)
    {
        e.AddTweenResult(null, e.tween.startValue);

        e.tween.endValue -= Consts.Epsilon_Float;

        bool repeat = e.tween.repeat;
        var tweener = DOTween.To(() => e.tweenResult.value, x => e.tweenResult.value = x, e.tween.endValue, e.tween.duration)
                        .SetLoops(repeat ? -1 : 1)
                        .OnKill(() => { e.tweenResult.tweener = null; });

        e.tweenResult.tweener = tweener;
    }
}
