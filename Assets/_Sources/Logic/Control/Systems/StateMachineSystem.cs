using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Entitas;
using RSG;
using UniRx;
using UnityEngine;

public class StateMachineSystem : ReactiveSystem<GameEntity>
{
    public StateMachineSystem(Contexts contexts)
        : base(contexts.game)
    {
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.AllOf(GameMatcher.State, GameMatcher.TweenResult));
    }

    protected override bool Filter(GameEntity entity)
    {
        return !entity.hasStateMachine && entity.hasState && entity.hasTweenResult;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            string currentState;
            IState fsm;

            GetStateMachine(e, out currentState, out fsm);

            e.AddStateMachine(currentState, fsm);

            fsm.ChangeState(currentState);
        }
    }

    private IStateBuilder<GameState, StateMachineBuilder> GetStateIdle(GameEntity entity, StateMachineBuilder builder)
    {
        return builder.State<GameState>(CharacterState.Idle.ToString())
            .Enter(state =>
            {
                // Debug.Log("!!! Enter state: Idle");
                state.InitState(entity, CharacterState.Idle);
            })
            .Event(CharacterState.Run.ToString(), state =>
            {
                // Debug.Log("!!! Idle -> Run");
                state.PushState(CharacterState.Run.ToString());
            })
            .Event(CharacterState.LightAttack1.ToString(), state =>
            {
                // Debug.Log("!!! Idle -> LightAttack1");
                state.PushState(CharacterState.LightAttack1.ToString());
            })
            .Event(CharacterState.LightAttack2.ToString(), state =>
            {
                // Debug.Log("!!! Idle -> LightAttack2");
                state.PushState(CharacterState.LightAttack2.ToString());
            })
            .Event(CharacterState.HeavyAttack1.ToString(), state =>
            {
                // Debug.Log("!!! Idle -> HeavyAttack1");
                state.PushState(CharacterState.HeavyAttack1.ToString());
            })
            .Event(CharacterState.HeavyAttack2.ToString(), state =>
            {
                // Debug.Log("!!! Idle -> HeavyAttack2");
                state.PushState(CharacterState.HeavyAttack2.ToString());
            })
            .Event(CharacterState.LevelUp.ToString(), state =>
            {
                // Debug.Log("!!! Idle -> LevelUp");
                state.PushState(CharacterState.LevelUp.ToString());
            })
            .Event(CharacterState.Die.ToString(), state =>
            {
                // Debug.Log("!!! Idle -> Die");
                state.PushState(CharacterState.Die.ToString());
            })

            .Exit(state =>
            {
                Debug.LogError("!!! Cannot Exite State: Idle");
            });
    }

    private IStateBuilder<GameState, StateMachineBuilder> GetStateRun(GameEntity entity, IStateBuilder<GameState, StateMachineBuilder> builder)
    {
        return builder.State<GameState>(CharacterState.Run.ToString())
            .Enter(state =>
            {
                // Debug.Log("!!! Enter state: Run");
                state.InitState(entity, CharacterState.Run);
            })
            .Event("ResetIdle", state =>
            {
                // Debug.Log("!!! AbortRun");
                state.Parent.PopState();
            })
            .Condition(() =>
                {
                    return !entity.hasVelocity ||
                           (Mathf.Approximately(entity.velocity.velocity.x, 0.0f) &&
                            Mathf.Approximately(entity.velocity.velocity.y, 0.0f));
                },
                state =>
                {
                    state.Parent.PopState();
                })

            .Exit(state =>
            {
                // Debug.Log("!!! Exit state: Run");
                state.ResetToIdle();
            })
            .End();
    }

    private IStateBuilder<GameState, StateMachineBuilder> GetStateAction(IStateBuilder<GameState, StateMachineBuilder> builder, GameEntity entity, CharacterState characterState)
    {
        return builder.State<GameState>(characterState.ToString())
            .Enter(state =>
            {
                // Debug.Log("!!! Enter state: " + characterState + ", frame: " + Time.frameCount);
                state.InitState(entity, characterState);
            })
            .Event("ResetIdle", state =>
            {
                // Debug.Log("!!! Abort state: " + characterState + ", frame: " + Time.frameCount);
                state.Parent.PopState();
            })
            .Exit(state =>
            {
                // Debug.Log("!!! Exit state: " + characterState + ", frame: " + Time.frameCount);
                state.ResetToIdle();
            })
            .End();
    }

    private void GetStateMachine(GameEntity entity, out string currentState, out IState fsm)
    {
        var builder = new StateMachineBuilder();
        var idleState = GetStateIdle(entity, builder);
        {
            var runState = GetStateRun(entity, idleState);

            var lightAttack1State = GetStateAction(runState, entity, CharacterState.LightAttack1);
            var lightAttack2State = GetStateAction(lightAttack1State, entity, CharacterState.LightAttack2);
            var heavyAttack1State = GetStateAction(lightAttack2State, entity, CharacterState.HeavyAttack1);
            var heavyAttack2State = GetStateAction(heavyAttack1State, entity, CharacterState.HeavyAttack2);
            var levelUpState = GetStateAction(heavyAttack2State, entity, CharacterState.LevelUp);
            GetStateAction(levelUpState, entity, CharacterState.Die);
        }

        currentState = entity.state.state.ToString();

        fsm = builder.Build();
    }

}

public class GameState : AbstractState
{
    private GameEntity _entity;

    public void InitState(GameEntity entity, CharacterState state)
    {
        _entity = entity;

        if (state != CharacterState.Idle && state != CharacterState.Run)
        {
            DelayPopState();
        }

        entity.ReplaceStateMachine(state.ToString(), entity.stateMachine.fsm);
        entity.ReplaceState(state);
    }

    // idle and running is not one-time animation
    // other actions is one-time animation
    private void DelayPopState()
    {
        var tweener = _entity.tweenResult.tweener;

        tweener.OnKill(() =>
        {
            // Debug.Log("!!! Kill State " + Time.frameCount);
            this.Parent.PopState();
        });
    }

    public void ResetToIdle()
    {
        _entity.ReplaceState(CharacterState.Idle);

        var fsm = _entity.stateMachine.fsm;
        _entity.ReplaceStateMachine(CharacterState.Idle.ToString(), fsm);
    }
}
