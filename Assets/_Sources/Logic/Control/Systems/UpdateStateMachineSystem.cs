using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class UpdateStateMachineSystem : IExecuteSystem
{
    private IGroup<GameEntity> _stateMachineElements;

    public UpdateStateMachineSystem(Contexts contexts)
    {
        var context = contexts.game;

        _stateMachineElements = context.GetGroup(GameMatcher.StateMachine);
    }

    public void Execute()
    {
        foreach (var e in _stateMachineElements.GetEntities())
        {
            e.stateMachine.fsm.Update(Time.deltaTime);
        }
    }
}

