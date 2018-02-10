using System;
using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class EmitInputSystem : IExecuteSystem, ICleanupSystem
{
    private readonly InputContext _inputContext;
    private readonly IGroup<InputEntity> _inputGroup;

    private readonly Action[] _buttonActions = new Action[6];

    public EmitInputSystem(Contexts contexts)
    {
        _inputContext = contexts.input;
        _inputGroup = _inputContext.GetGroup(InputMatcher.AnyOf(InputMatcher.InputMove, InputMatcher.InputAction));

        _buttonActions = new Action[6];
        _buttonActions[(int)MappedButton.LightAttack1] = () => { _inputContext.CreateEntity().AddInputAction(CharacterState.LightAttack1); };
        _buttonActions[(int)MappedButton.LightAttack2] = () => { _inputContext.CreateEntity().AddInputAction(CharacterState.LightAttack2); };
        _buttonActions[(int)MappedButton.HeavyAttack1] = () => { _inputContext.CreateEntity().AddInputAction(CharacterState.HeavyAttack1); };
        _buttonActions[(int)MappedButton.HeavyAttack2] = () => { _inputContext.CreateEntity().AddInputAction(CharacterState.HeavyAttack2); };
        _buttonActions[(int)MappedButton.LevelUp] = () => { _inputContext.CreateEntity().AddInputAction(CharacterState.LevelUp); };
        _buttonActions[(int)MappedButton.Die] = () => { _inputContext.CreateEntity().AddInputAction(CharacterState.Die); };
    }

    public void Execute()
    {
        // move
        Vector2 moveVector = GetInput();
        float horizontal = moveVector.x;
        float vertical = moveVector.y;

        if (!Mathf.Approximately(horizontal, 0.0f) || !Mathf.Approximately(vertical, 0.0f))
        {
            _inputContext.CreateEntity().AddInputMove(horizontal, vertical);
        }

        // action
        for (int i = 0, length = _buttonActions.Length; i < length; ++i)
        {
            if (IsButtonDown((MappedButton)i))
            {
                _buttonActions[i]();
            }
        }
    }

    private bool IsButtonDown(MappedButton buttonIndex)
    {
        List<InputDevice> devices = MappedInput.inputDevices;
        for (int i = 0, length = devices.Count; i < length; ++i)
        {
            var device = devices[i];

            if (device.GetButtonDown((MappedButton)buttonIndex))
                return true;
        }

        // re think
        List<GamepadDevice> gamepadDevices = MappedInput.instance.gamepadInput.gamepads;
        for (int i = 0, length = gamepadDevices.Count; i < length; ++i)
        {
            var device = gamepadDevices[i];

            if (device.GetButtonDown((GamepadButton)buttonIndex))
                return true;
        }

        return false;
    }

    private Vector2 GetKBControllerInput()
    {
        Vector2 input = new Vector2();

        List<InputDevice> devices = MappedInput.inputDevices;
        for (int i = 0, length = devices.Count; i < length; ++i)
        {
            var device = devices[i];

            input.x += device.GetAxisButton(MappedAxis.Horizontal, AxisDirection.Positive) ? 1.0f : 0.0f;
            input.x += device.GetAxisButton(MappedAxis.Horizontal, AxisDirection.Negative) ? -1.0f : 0.0f;

            input.y += device.GetAxisButton(MappedAxis.Vertical, AxisDirection.Positive) ? 1.0f : 0.0f;
            input.y += device.GetAxisButton(MappedAxis.Vertical, AxisDirection.Negative) ? -1.0f : 0.0f;
        }

        List<GamepadDevice> gamepadDevices = MappedInput.instance.gamepadInput.gamepads;
        for (int i = 0, length = gamepadDevices.Count; i < length; ++i)
        {
            var device = gamepadDevices[i];

            input.x += device.GetAxis(GamepadAxis.LeftStickX);
            input.y += device.GetAxis(GamepadAxis.LeftStickY);
        }

        return input;
    }

    static Vector2 GetKBInput()
    {
        return new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    Vector2 touchOrigin = -Vector2.one;

    Vector2 GetInput()
    {
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_ANDROID || UNITY_WP8 || UNITY_IPHONE)
        return GetTouchInput();
#else
        // return GetKBInput();
        return GetKBControllerInput();
#endif
    }

    Vector2 GetTouchInput()
    {
        //Check if Input has registered more than zero touches
        if (Input.touchCount <= 0)
        {
            return Vector2.zero;
        }

        float horizontal = 0.0f;
        float vertical = 0.0f;

        Touch firstTouch = Input.touches[0];

        //Check if the phase of that touch equals Began
        if (firstTouch.phase == TouchPhase.Began)
        {
            //If so, store position of that touch for later calculations
            touchOrigin = firstTouch.position;
        }
        else if (firstTouch.phase == TouchPhase.Ended && touchOrigin.x >= 0)
        {
            Vector2 touchEnd = firstTouch.position;
            horizontal = touchEnd.x - touchOrigin.x;
            vertical = touchEnd.y - touchOrigin.y;

            // Set touchOrigin.x to -1 so that our else if statement will 
            // evaluate false and not repeat immediately.
            touchOrigin.x = -1;
        }

        return new Vector2(horizontal, vertical);
    }


    public void Cleanup()
    {
        foreach (var e in _inputGroup.GetEntities())
        {
            e.Destroy();
        }
    }
}
