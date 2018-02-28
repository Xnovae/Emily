using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class ProcessInputActionSystem : ReactiveSystem<InputEntity>
{
    private readonly IGroup<GameEntity> _controllableEntities;

    public Dictionary<CharacterState, string> stateStringCache = new Dictionary<CharacterState, string>(8);

    public ProcessInputActionSystem(Contexts contexts)
        : base(contexts.input)
    {
        _controllableEntities =
            contexts.game.GetGroup(GameMatcher.AllOf(GameMatcher.Controllable, GameMatcher.StateMachine));

        stateStringCache.Add(CharacterState.Idle, CharacterState.Idle.ToString());
        stateStringCache.Add(CharacterState.Run, CharacterState.Run.ToString());
        stateStringCache.Add(CharacterState.LightAttack1, CharacterState.LightAttack1.ToString());
        stateStringCache.Add(CharacterState.LightAttack2, CharacterState.LightAttack2.ToString());
        stateStringCache.Add(CharacterState.HeavyAttack1, CharacterState.HeavyAttack1.ToString());
        stateStringCache.Add(CharacterState.HeavyAttack2, CharacterState.HeavyAttack2.ToString());
        stateStringCache.Add(CharacterState.LevelUp, CharacterState.LevelUp.ToString());
        stateStringCache.Add(CharacterState.Die, CharacterState.Die.ToString());
    }

    protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
    {
        return context.CreateCollector(InputMatcher.InputAction);
    }

    protected override bool Filter(InputEntity entity)
    {
        return entity.hasInputAction;
    }

    protected override void Execute(List<InputEntity> entities)
    {
        for (int i = 0, length = entities.Count; i < length; ++i)
        {
            var e = entities[i];
            var inputAction = e.inputAction;

            ProcessAction(inputAction.state);
        }
    }

    private void ProcessAction(CharacterState newState)
    {
        foreach (var e in _controllableEntities.GetEntities())
        {
            // TODO fix too early
            e.stateMachine.fsm.TriggerEvent("ResetToIdle");
            e.stateMachine.fsm.TriggerEvent(stateStringCache[newState]);
        }
    }
}
