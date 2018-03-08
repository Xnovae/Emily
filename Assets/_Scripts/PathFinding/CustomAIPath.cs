using System.Collections;
using System.Collections.Generic;
using Entitas.Unity;
using UnityEngine;

public class CustomAIPath : AIPath
{
    private Transform _transform;

    public bool IsMoving
    {
        get { return target != null; }
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
    }

    public void MoveToTarget(GameObject targetGameObject)
    {
        // good to go
        target = targetGameObject.transform;

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
        target = null;
    }
}
