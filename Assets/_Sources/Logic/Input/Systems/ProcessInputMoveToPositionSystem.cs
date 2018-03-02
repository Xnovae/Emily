using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;
using UnityEngine.Assertions;

public class ProcessInputMoveToPositionSystem : ReactiveSystem<InputEntity>, IInitializeSystem
{
    public static readonly string STRING_FSM_RUN = "Run";

    private IGroup<GameEntity> _controllableGroup;

    private Transform _targetTransform;

    public ProcessInputMoveToPositionSystem(Contexts contexts)
        : base(contexts.input)
    {
        _controllableGroup = contexts.game.GetGroup(GameMatcher.Controllable);
    }

    public void Initialize()
    {
        GameObject obj = new GameObject("PressPosition");
        _targetTransform = obj.transform;
    }


    protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
    {
        return context.CreateCollector(InputMatcher.InputMoveToPosition.Added());
    }

    protected override bool Filter(InputEntity entity)
    {
        return true;
    }

    protected override void Execute(List<InputEntity> entities)
    {
        // TODO: still has bug, comment out
        //var inputEntity = entities.SingleEntity();
        //var input = inputEntity.inputMoveToPosition;

        //_targetTransform.position = new Vector3(input.x, input.y);

        //foreach (var e in _controllableGroup.GetEntities())
        //{
        //    Assert.IsTrue(e.hasView);

        //    AIPath aiPath = e.view.viewController.gameObject.GetComponent<AIPath>();
        //    Assert.IsNotNull(aiPath);

        //    aiPath.target = _targetTransform;
        //}

        //inputEntity.Destroy();
    }

}
