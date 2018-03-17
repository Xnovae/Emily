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

        // WTF: ChangeValue Object, Object, causing box
        tweener.ChangeValues(startValue, endValue, duration);
        tweener.fullPosition = e.isTweenResultPreserved ? oldTweenValue : 0.0f;

        if (!repeat)
        {
            // Only none-repeat Action need check OnComplete
            SetStepComplete(e);
        }
        else
        {
            tweener.OnStepComplete(null);
        }
    }

    private void SetStepComplete(GameEntity e)
    {
        Tweener tweener = e.tweenResult.tweener;
        tweener.OnStepComplete(() =>
        {
            bool complated = tweener.CompletedLoops() == 1;
            if (complated && e.hasStateMachine)
            {
                e.stateMachine.fsm.TriggerEvent("OnTweenComplete");
            }

            tweener.OnStepComplete(null);
        });
    }

    private void AddTweenResult(GameEntity e)
    {
        e.AddTweenResult(null, e.tween.startValue);

        e.tween.endValue -= Consts.Epsilon_Float;

        bool repeat = e.tween.repeat;
        var tweener = DOTween.To(() => e.tweenResult.value, x => e.tweenResult.value = x, e.tween.endValue, e.tween.duration)
            .SetLoops(repeat ? -1 : 1)
            .SetEase(Ease.Linear)
            .OnKill(() => { e.tweenResult.tweener = null; });

        e.tweenResult.tweener = tweener;
    }
}
