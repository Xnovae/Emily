using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;
using UnityEngine.Assertions;

public class VelocitySystem : ReactiveSystem<GameEntity>
{
    public VelocitySystem(Contexts contexts)
        : base(contexts.game)
    {
        
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Velocity);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasVelocity && entity.hasDirection && entity.hasState;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            // only process when running
            if (e.state.state != CharacterState.Run)
                continue;

            var newPosition = e.position.value + e.velocity.velocity * Time.deltaTime;
            // e.ReplacePosition(newPosition);
            e.AddAttempPosition(newPosition);

            CharacterDirection newDirection = GetCharacterDirection(e.velocity.velocity.x, e.velocity.velocity.y);
            if (newDirection != CharacterDirection.None)
            {
                CharacterDirection oldDirection = e.direction.direction;

                if (newDirection != oldDirection)
                {
                    e.ReplaceDirection(newDirection);
                }
            }

            float angle = Mathf.Atan2(e.velocity.velocity.y, e.velocity.velocity.x) * Mathf.Rad2Deg;
            angle = Mathf.Repeat(angle, 360.0f);
            e.ReplaceLastDirection(angle);
        }
    }

    private CharacterDirection GetCharacterDirection(float x, float y)
    {
        Assert.IsTrue(!Mathf.Approximately(x, 0.0f) || !Mathf.Approximately(y, 0.0f));

        if (x > 0.0f)
        {
            return CharacterDirection.Right;
        }
        else if (x < 0.0f)
        {
            return CharacterDirection.Left;
        }
        else
        {
            return CharacterDirection.None;
        }
    }
}
