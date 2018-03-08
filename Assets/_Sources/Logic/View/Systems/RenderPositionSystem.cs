using System.Collections;
using System.Collections.Generic;
using ClientConfig;
using Entitas;
using UnityEngine;

public class RenderPositionSystem : ReactiveSystem<GameEntity>
{
    public RenderPositionSystem(Contexts contexts)
        : base(contexts.game)
    {
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Position);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasPosition && entity.hasView;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            if (e.hasIdentifier)
            {
                string id = e.identifier.name;
                var characterItem = ConfigManager.Instance.GetItem<CharacterItem>(Consts.ASSET_NAME_CHARACTER, id);

                Vector2 renderOffset = new Vector2(characterItem.renderOffsetX, characterItem.renderOffsetY);

                Vector3 position = new Vector3(e.position.x + renderOffset.x, e.position.y + renderOffset.y, 0);
                e.view.viewController.position = position;
            }
            else
            {
                Vector3 position = new Vector3(e.position.x, e.position.y, 0);
                e.view.viewController.position = position;
            }
        }
    }
}
