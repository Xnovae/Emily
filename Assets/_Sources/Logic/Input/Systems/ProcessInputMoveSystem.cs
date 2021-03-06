using System.Collections;
using System.Collections.Generic;
using ApproximationNET;
using Entitas;
using UnityEngine;
using UnityEngine.Assertions;

public class ProcessInputMoveSystem : ReactiveSystem<InputEntity>, ICleanupSystem
{
    private GameContext _gameContext;

    private readonly IGroup<GameEntity> _controllableEntities;
    private readonly IGroup<GameEntity> _velocityEntities;

    private List<GameEntity> _cleanBuffer = new List<GameEntity>();

    public ProcessInputMoveSystem(Contexts contexts)
        : base(contexts.input)
    {
        _gameContext = contexts.game;

        _controllableEntities = _gameContext.GetGroup(GameMatcher.AllOf(GameMatcher.Controllable, GameMatcher.StateMachine));
        _velocityEntities = _gameContext.GetGroup(GameMatcher.Velocity);
    }

    protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
    {
        return context.CreateCollector(InputMatcher.InputMove);
    }

    protected override bool Filter(InputEntity entity)
    {
        return entity.hasInputMove;
    }

    protected override void Execute(List<InputEntity> entities)
    {
        var inputEntity = entities.SingleEntity();
        var input = inputEntity.inputMove;

        // process Velocity
        foreach (var controllableEntity in _controllableEntities.GetEntities())
        {
            var velocity = ToVelocity(input.x, input.y);
            controllableEntity.AddVelocity(velocity.x, velocity.y);

            // trigger Run
            controllableEntity.stateMachine.fsm.TriggerEvent(Consts.STRING_FSM_RUN);
        }
    }

    private static Vector2 ToVelocity(float x, float y)
    {
        Assert.IsTrue(!Mathf.Approximately(x, 0.0f) || !Mathf.Approximately(y, 0.0f));

        float inverseSqrtLength = Approximation.InvSqrt(x * x + y * y); // => 1 / Mathf.Sqrt(x*x + y*y);
        Vector2 velocity = new Vector2(x * inverseSqrtLength, y * inverseSqrtLength);

        velocity = velocity * 2;

        return velocity;
    }

    public void Cleanup()
    {
        foreach (var e in _velocityEntities.GetEntities(_cleanBuffer))
        {
            e.RemoveVelocity();
        }
    }
}
