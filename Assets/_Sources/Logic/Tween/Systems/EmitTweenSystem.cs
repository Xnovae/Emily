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
                AddTweenResult(e, 0.0f);
            }
            else
            {
                // ReplaceTweenResult(e);

                float startValue = e.isTweenResultPreserved ? e.tweenResult.tweener.fullPosition : 0.0f;

                e.tweenResult.tweener.Kill(false);
                e.RemoveTweenResult();

                AddTweenResult(e, startValue);
            }
        }
    }

    private void AddTweenResult(GameEntity e, float startValue)
    {
        e.AddTweenResult(null, e.tween.startValue);

        e.tween.endValue -= Consts.Epsilon_Float;

        bool repeat = e.tween.repeat;
        var tweener = DOTween.To(() => e.tweenResult.value, x => e.tweenResult.value = x, e.tween.endValue, e.tween.duration)
                        .SetLoops(repeat ? -1 : 1)
                        .SetEase(Ease.Linear)
                        .OnComplete(() =>
                        {
                            // trigger state machine
                            if (e.hasStateMachine)
                            {
                                e.stateMachine.fsm.TriggerEvent("OnTweenComplete");
                            }

                            e.tweenResult.tweener = null;
                        });
        tweener.fullPosition = startValue;

        e.tweenResult.tweener = tweener;
    }
}
