using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Entitas;
using UnityEngine;

public class RenderOrderSystem : IInitializeSystem, IExecuteSystem
{
    private GameContext _gameContext;

    private IGroup<GameEntity> _positionGroup;

    private bool _entityPositionChange;

    public RenderOrderSystem(Contexts contexts)
    {
        _gameContext = contexts.game;
    }

    public void Initialize()
    {
        _positionGroup = _gameContext.GetGroup(GameMatcher.Position);

        _positionGroup.OnEntityAdded += (group, entity, index, component) =>
        {
            OnEntityPositionChange();
        };
        _positionGroup.OnEntityUpdated += (group, entity, index, component, newComponent) =>
        {
            OnEntityPositionChange();
        };
    }

    private void OnEntityPositionChange()
    {
        _entityPositionChange = true;
    }

    private static int ComparePosition(GameEntity a, GameEntity b)
    {
        return b.position.y.CompareTo(a.position.y);
    }

    public void Execute()
    {
        if (_entityPositionChange)
        {
            var entities = _positionGroup.GetEntities();

            entities.TimSort(ComparePosition);

            for (int i = 0, length = entities.Length; i < length; ++i)
            {
                var entity = entities[i];
                entity.view.viewController.displaySprite.SortingOrder = i;
            }

            _entityPositionChange = false;
        }
    }
}
