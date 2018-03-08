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

            float x = e.position.x + e.velocity.x * Time.deltaTime;
            float y = e.position.y + e.velocity.y * Time.deltaTime;
            e.AddAttempPosition(x, y);

            CharacterDirection newDirection = Utils.GetCharacterDirection(e.velocity.x, e.velocity.y);
            if (newDirection != CharacterDirection.None)
            {
                CharacterDirection oldDirection = e.direction.direction;

                if (newDirection != oldDirection)
                {
                    e.ReplaceDirection(newDirection);
                }
            }

            float angle = Mathf.Atan2(e.velocity.y, e.velocity.x) * Mathf.Rad2Deg;
            angle = Mathf.Repeat(angle, 360.0f);
            e.ReplaceLastDirection(angle);
        }
    }
}
