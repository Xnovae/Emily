using System;
using System.Collections;
using System.Collections.Generic;
using TouchScript.Gestures;
using TouchScript.Gestures.TransformGestures;
using UnityEngine;

public class GameGestureDispatcher : MonoBehaviour
{
    public ScreenTransformGesture screenTransformGesture;

    public PressGesture pressGesture;

    private Vector2 _touchStartPoint;
    private Vector2 _touchEndPoint;

    private bool _isTransforming = false;

    private Camera _camera;

    void Awake()
    {
        _camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    private void OnEnable()
    {
        //screenTransformGesture.TransformStarted += OnTransformStart;
        //screenTransformGesture.Transformed += OnTransformUpdate;
        //screenTransformGesture.TransformCompleted += OnTransformComplete;

        pressGesture.Pressed += OnGesturePressed;
    }

    private void OnDisable()
    {
        //screenTransformGesture.TransformStarted -= OnTransformStart;
        //screenTransformGesture.Transformed -= OnTransformUpdate;
        //screenTransformGesture.TransformCompleted -= OnTransformComplete;

        pressGesture.Pressed -= OnGesturePressed;
    }

    void Update()
    {
        if (_isTransforming)
        {
            float horizontal = _touchEndPoint.x - _touchStartPoint.x;
            float vertical = _touchEndPoint.y - _touchStartPoint.y;

            if (!Mathf.Approximately(horizontal, 0.0f) || !Mathf.Approximately(vertical, 0.0f))
            {
                Contexts.sharedInstance.input.CreateEntity().AddInputMove(horizontal, vertical);
            }
        }
    }

    private void OnTransformStart(object sender, EventArgs e)
    {
        _isTransforming = true;

        ScreenTransformGesture gesture = (ScreenTransformGesture)sender;
        _touchStartPoint = gesture.NormalizedScreenPosition;
    }

    private void OnTransformUpdate(object sender, EventArgs e)
    {
        ScreenTransformGesture gesture = (ScreenTransformGesture) sender;
        _touchEndPoint = gesture.NormalizedScreenPosition;
    }

    private void OnTransformComplete(object sender, EventArgs e)
    {
        _isTransforming = false;
    }

    private void OnGesturePressed(object sender, EventArgs e)
    {
        PressGesture gesture = (PressGesture) sender;

        Vector2 position = Utils.ScreenToLogicPosition(_camera, gesture.NormalizedScreenPosition);

        Contexts.sharedInstance.input.CreateEntity().AddInputMoveToPosition(position.x, position.y);
    }
}
