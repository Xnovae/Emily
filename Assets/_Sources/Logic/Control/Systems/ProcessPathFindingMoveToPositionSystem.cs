using System.Collections;
using System.Collections.Generic;
using Entitas;
using Pathfinding;
using UnityEngine;
using UnityEngine.Assertions;

public class ProcessPathFindingMoveToPositionSystem : ReactiveSystem<GameEntity>
{
    private static NNConstraint walkableArea = NNConstraint.Default;

    private GameContext _gameContext;

    public ProcessPathFindingMoveToPositionSystem(Contexts contexts)
        : base(contexts.game)
    {
        _gameContext = contexts.game;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.PathFindingToPosition.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasPosition && entity.hasStateMachine && 
            entity.hasState && (entity.state.state == CharacterState.Idle || entity.state.state == CharacterState.Run);
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            Vector3 targetPosition = new Vector3(e.pathFindingToPosition.x, e.pathFindingToPosition.y, 0.0f);
            Vector3 nearestPosition = AstarPath.active.GetNearest(targetPosition, walkableArea).position;

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

            e.RemovePathFindingToPosition();
        }
    }
}
