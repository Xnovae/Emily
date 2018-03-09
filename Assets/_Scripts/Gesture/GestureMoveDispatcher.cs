using System;
using System.Collections;
using System.Collections.Generic;
using Entitas.Unity;
using TouchScript.Gestures.TransformGestures;
using UnityEngine;
using UnityEngine.Assertions;

public class GestureMoveDispatcher : MonoBehaviour
{
    public TransformGesture transformGesture;

    private Camera _camera;

    private void Awake()
    {
        _camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    private void OnEnable()
    {
        transformGesture.TransformStarted += OnTransformStart;
        transformGesture.Transformed += OnTransformUpdate;
        transformGesture.TransformCompleted += OnTransformComplete;
    }

    private void OnTransformStart(object sender, EventArgs e)
    {
        // Debug.Log("!!! start");
    }

    private void OnTransformUpdate(object sender, EventArgs e)
    {
        // Debug.Log("!!! update");
    }

    private void OnTransformComplete(object sender, EventArgs e)
    {
        // Debug.Log("!!! Complete");
        TransformGesture gesture = (TransformGesture)sender;

        Vector2 position = Utils.ScreenToLogicPosition(_camera, gesture.NormalizedScreenPosition);

        GameEntity entity = gameObject.GetEntityLink().entity as GameEntity;
        Assert.IsNotNull(entity);

        entity.AddPathFindingToPosition(entity, position.x, position.y);
    }

    private void OnDisable()
    {
        transformGesture.TransformStarted -= OnTransformStart;
        transformGesture.Transformed -= OnTransformUpdate;
        transformGesture.TransformCompleted -= OnTransformComplete;
    }
}
