using System;
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
        return !entity.hasStateMachine && entity.hasState;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            IState fsm = InitFSM(e);

            string initState = Consts.GetStateString(e.state.state);
            fsm.ChangeState(initState);

            e.AddStateMachine(fsm);
        }
    }

    private IState InitFSM(GameEntity e)
    {
        return new StateMachineBuilder()
            .State<GameState>(Consts.GetStateString(CharacterState.Idle))
            .Enter(state =>
            {
                // Debug.Log("!!! Enter idle");
            })
            // Events
            .Event(Consts.GetStateString(CharacterState.Run), state =>
            {
                // Debug.Log("!!! Event run frame: " + Time.frameCount);
                state.PushState(Consts.GetStateString(CharacterState.Run));
            })
            .Event(Consts.GetStateString(CharacterState.LightAttack1), state =>
            {
                // Debug.Log("!!! Event LightAttack1 frame: " + Time.frameCount);
                state.PushState(Consts.GetStateString(CharacterState.LightAttack1));
            })
            .Event(Consts.GetStateString(CharacterState.LightAttack2), state =>
            {
                state.PushState(Consts.GetStateString(CharacterState.LightAttack2));
            })
            .Event(Consts.GetStateString(CharacterState.HeavyAttack1), state =>
            {
                state.PushState(Consts.GetStateString(CharacterState.HeavyAttack1));
            })
            .Event(Consts.GetStateString(CharacterState.HeavyAttack2), state =>
            {
                state.PushState(Consts.GetStateString(CharacterState.HeavyAttack2));
            })
            .Event(Consts.GetStateString(CharacterState.LevelUp), state =>
            {
                state.PushState(Consts.GetStateString(CharacterState.LevelUp));
            })
            .Event(Consts.GetStateString(CharacterState.Die), state =>
            {
                state.PushState(Consts.GetStateString(CharacterState.Die));
            })

            .Exit(state => 
            {
                // Debug.Log("!!! Exit idle frame: " + Time.frameCount);
                throw new Exception("Can NOT exit Idle");
            })

            // Run
            .State<GameState>(Consts.GetStateString(CharacterState.Run))
            .Enter(state =>
            {
                // Debug.Log("!!! Enter run frame: " + Time.frameCount);
                e.ReplaceState(CharacterState.Run);
            })
            .Event("ResetToIdle", state =>
            {
                // Debug.Log("!!! Event ResetIdle frame: " + Time.frameCount);
                state.Parent.PopState();
            })
            .Condition(() =>
                {
                    if (e.isAIMoving)
                    {
                        return false;
                    }
                    else
                    {
                        if (e.hasVelocity
                            && (!Mathf.Approximately(0.0f, e.velocity.x) || !Mathf.Approximately(0.0f, e.velocity.y)))
                        {
                            return false;
                        }
                    }

                    return true;
                },
                state =>
                {
                    // Debug.Log("!!! Condition Run frame: " + Time.frameCount);
                    state.Parent.PopState();
                })
            .Exit(state =>
            {
                // Debug.Log("!!! Exit run frame: " + Time.frameCount);
                e.ReplaceState(CharacterState.Idle);
            })
            .End()

            // LightAttack1
            .State<GameState>(Consts.GetStateString(CharacterState.LightAttack1))
            .Enter(state =>
            {
                // Debug.Log("!!! Enter action frame: " + Time.frameCount);
                e.isAIMoving = false;
                e.ReplaceState(CharacterState.LightAttack1);
            })
            .Event("OnTweenComplete", state =>
            {
                // Debug.Log("!!! OnTweenComplete frame: " + Time.frameCount);
                state.Parent.PopState();
            })
            .Exit(state =>
            {
                // Debug.Log("!!! Exit action frame: " + Time.frameCount);
                // Bug: exit at n, but ilde action starts at n+2
                e.ReplaceState(CharacterState.Idle);
            })
            .End()

             // LightAttack2
            .State<GameState>(Consts.GetStateString(CharacterState.LightAttack2))
            .Enter(state =>
            {
                e.isAIMoving = false;
                e.ReplaceState(CharacterState.LightAttack2);
            })
            .Event("OnTweenComplete", state =>
            {
                state.Parent.PopState();
            })
            .Exit(state =>
            {
                e.ReplaceState(CharacterState.Idle);
            })
            .End()

            // HeavyAttack1
            .State<GameState>(Consts.GetStateString(CharacterState.HeavyAttack1))
            .Enter(state =>
            {
                e.isAIMoving = false;
                e.ReplaceState(CharacterState.HeavyAttack1);
            })
            .Event("OnTweenComplete", state =>
            {
                state.Parent.PopState();
            })
            .Exit(state =>
            {
                e.ReplaceState(CharacterState.Idle);
            })
            .End()

            // HeavyAttack2
            .State<GameState>(Consts.GetStateString(CharacterState.HeavyAttack2))
            .Enter(state =>
            {
                e.isAIMoving = false;
                e.ReplaceState(CharacterState.HeavyAttack2);
            })
            .Event("OnTweenComplete", state =>
            {
                state.Parent.PopState();
            })
            .Exit(state =>
            {
                e.ReplaceState(CharacterState.Idle);
            })
            .End()

            // LevelUp
            .State<GameState>(Consts.GetStateString(CharacterState.LevelUp))
            .Enter(state =>
            {
                e.isAIMoving = false;
                e.ReplaceState(CharacterState.LevelUp);
            })
            .Event("OnTweenComplete", state =>
            {
                state.Parent.PopState();
            })
            .Exit(state =>
            {
                e.ReplaceState(CharacterState.Idle);
            })
            .End()

            // Die
            .State<GameState>(Consts.GetStateString(CharacterState.Die))
            .Enter(state =>
            {
                e.isAIMoving = false;
                e.ReplaceState(CharacterState.Die);
            })
            .Event("OnTweenComplete", state =>
            {
                state.Parent.PopState();
            })
            .Exit(state =>
            {
                e.ReplaceState(CharacterState.Idle);
            })
            .End()

        .End()
        .Build();
    }

    class GameState : AbstractState
    {
    }
}


