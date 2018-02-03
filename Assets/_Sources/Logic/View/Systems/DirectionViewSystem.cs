using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;
using UnityEngine.Assertions;

public class DirectionViewSystem : ReactiveSystem<GameEntity>
{
    public DirectionViewSystem(Contexts contexts)
        : base(contexts.game)
    {
        
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Direction);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasView;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            tk2dSprite sprite = e.view.viewController.tk2dSprite;
            if (e.direction.direction == CharacterDirection.Right)
            {
                sprite.FlipX = false;
            }
            else if (e.direction.direction == CharacterDirection.Left)
            {
                sprite.FlipX = true;
            }
            else
            {
                Assert.IsTrue(false, "DirectionSystem::Execute unknown direction: " + e.direction.direction);
            }
        }
    }
}
