using System.Collections;
using System.Collections.Generic;
using Entitas.Unity;
using Pathfinding;
using UnityEngine;

public class CustomAIPath : AIPath
{
    private Transform _transform;

    private AIDestinationSetter _aiDestinationSetter;

    public bool IsMoving
    {
        get { return _aiDestinationSetter.targetASTAR != null; }
    }

    public Vector3 CurrentPosition
    {
        get { return _transform.position; }
    }

    public Vector2 CurrentVelocity
    {
        get { return velocity2D; }
    }

    protected override void Awake()
    {
        base.Awake();

        _transform = gameObject.transform;

        _aiDestinationSetter = GetComponent<AIDestinationSetter>();
    }

    public void MoveToTarget(GameObject targetGameObject)
    {
        enabled = true;

        // good to go
        _aiDestinationSetter.targetASTAR = targetGameObject.transform;

        OnMovingStart();
    }

    public override void OnTargetReached()
    {
        base.OnTargetReached();

        OnMovingEnd();
    }

    private void OnMovingStart()
    {
    }

    private void OnMovingEnd()
    {
        _aiDestinationSetter.targetASTAR = null;
        destination = Vector3.positiveInfinity;
        enabled = false;
    }
}
