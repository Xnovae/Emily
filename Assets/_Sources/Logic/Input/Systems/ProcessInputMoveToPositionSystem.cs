using System.Collections;
using System.Collections.Generic;
using Entitas;
using Pathfinding;
using UnityEngine;
using UnityEngine.Assertions;

public class ProcessInputMoveToPositionSystem : ReactiveSystem<InputEntity>
{
    private static NNConstraint walkableArea = NNConstraint.Default;

    private GameContext _gameContext;

    private IGroup<GameEntity> _controllableGroup;

    public ProcessInputMoveToPositionSystem(Contexts contexts)
        : base(contexts.input)
    {
        _gameContext = contexts.game;

        _controllableGroup = _gameContext.GetGroup(GameMatcher.Controllable);
    }

    protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
    {
        return context.CreateCollector(InputMatcher.PathFindingToPosition.Added());
    }

    protected override bool Filter(InputEntity entity)
    {
        return true;
    }

    protected override void Execute(List<InputEntity> entities)
    {
        var inputEntity = entities.SingleEntity();
        var input = new Vector2(inputEntity.pathFindingToPosition.x, inputEntity.pathFindingToPosition.y);

        Vector3 targetPosition = new Vector3(input.x, input.y);
        Vector3 nearestPosition = AstarPath.active.GetNearest(targetPosition, walkableArea).position;

        foreach (var e in _controllableGroup.GetEntities())
        {
            Assert.IsTrue(e.hasPosition);
            Assert.IsTrue(e.hasStateMachine);

            if (e.state.state == CharacterState.Idle || e.state.state == CharacterState.Run)
            {
                FindPathToPosition(e, nearestPosition);
            }
        }

        inputEntity.Destroy();
    }

    private void FindPathToPosition(GameEntity e, Vector3 nearestPosition)
    {
        // 生成 seeker 和 target，然后UpdateMove设置位置，最后释放
        if (e.hasPathFinding)
        {
            e.pathFinding.target.transform.position = nearestPosition;
            e.pathFinding.aiPath.MoveToTarget(e.pathFinding.target);
        }
        else
        {
            Vector2 startPosition = new Vector2(e.position.x, e.position.y);

            var seekerPrefab = _gameContext.runningData.ResourceData.pathFindingSeekerTempldate;
            var targetPrefab = _gameContext.runningData.ResourceData.pathFindingTargetTempldate;

            GameObject seeker = PoolManager.Instance.SpawnObject(seekerPrefab);
            seeker.transform.position = new Vector3(startPosition.x, startPosition.y, 0);
            CustomAIPath aiPath = seeker.GetComponent<CustomAIPath>();

            GameObject target = PoolManager.Instance.SpawnObject(targetPrefab);
            target.transform.position = nearestPosition;

            aiPath.MoveToTarget(target);

            e.ReplacePathFinding(aiPath, target);
        }
    }
}
