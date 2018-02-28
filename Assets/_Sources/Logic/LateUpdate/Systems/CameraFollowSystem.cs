using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;
using UnityEngine.Assertions;

public class CameraFollowSystem : IInitializeSystem, IExecuteSystem
{
    private Camera _camera;
    private Transform _cameraTransform;
    private CameraFollowParameter _cameraFollowParameter;

    private Transform _playerTransform;

    private GameContext _gameContext;

    public CameraFollowSystem(Contexts contexts)
    {
        _gameContext = contexts.game;
    }

    public void Initialize()
    {
        // camera
        GameObject mainCamera = GameObject.FindGameObjectWithTag(Consts.TAG_MAIN_CAMERA);
        Assert.IsNotNull(mainCamera);

        _camera = mainCamera.GetComponent<Camera>();
        _cameraTransform = mainCamera.transform;
        _cameraFollowParameter = mainCamera.GetComponent<CameraFollowParameter>();
    }

    public void Execute()
    {
        RetrivePlayerTransform();

        if (_playerTransform == null)
            return;


        Vector3 cameraPosition = _cameraTransform.position;

        Vector3 focusPosition = GetFocusPosition();

        Vector3 newPosition = Vector3.Lerp(cameraPosition, focusPosition,
            _cameraFollowParameter.smooth * Time.deltaTime);
        newPosition.z = cameraPosition.z;

        _cameraTransform.position = newPosition;
    }

    private Vector3 GetFocusPosition()
    {
        Vector3 playerPos = _playerTransform.position;

        Vector4 viewBounds = GetViewBounds(playerPos.x, playerPos.y);

        float mapLogicWidth = (float) _gameContext.runningData.RuntimeData.mapWidth / Consts.TexturePixelsPerUnit;
        float mapLogicHeight = (float) _gameContext.runningData.RuntimeData.mapHeight / Consts.TexturePixelsPerUnit;

        float viewWidth = viewBounds.z;
        float viewHeight = viewBounds.w;

        float focusX = -1;

        if (viewWidth >= mapLogicWidth)
        {
            focusX = mapLogicWidth / 2;
        }
        else
        {
            focusX = playerPos.x;

            float left = viewBounds.x;
            float right = left + viewBounds.z;
            if (left < 0)
            {
                focusX = focusX + (-left);
            }
            if (right > mapLogicWidth)
            {
                focusX = focusX - (right - mapLogicWidth);
            }

            focusX = Mathf.Clamp(focusX, 0, mapLogicWidth);
        }

        float focusY = -1;
        if (viewHeight >= mapLogicHeight)
        {
            focusY = mapLogicHeight / 2;
        }
        else
        {
            focusY = playerPos.y;

            float bottom = viewBounds.y;
            float top = bottom + viewBounds.w;
            if (bottom < 0)
            {
                focusY = focusY + (-bottom);
            }
            if (top > mapLogicHeight)
            {
                focusY = focusY - (top - mapLogicHeight);
            }

            focusY = Mathf.Clamp(focusY, 0, mapLogicHeight);
        }

        return new Vector3(focusX, focusY, 0);
    }

    private void RetrivePlayerTransform()
    {
        if (_playerTransform != null)
            return;

        GameObject player = GameObject.FindGameObjectWithTag(Consts.TAG_PLAYER);
        if (player)
        {
            _playerTransform = player.transform;
        }
    }

    private Vector4 GetViewBounds(float centerX, float centerY)
    {
        Vector4 cameraBounds = new Vector4();

        float cameraHeightSize = _camera.orthographicSize;
        float cameraWidthSize = _camera.aspect * cameraHeightSize;

        cameraBounds.x = centerX - cameraWidthSize;
        cameraBounds.y = centerY - cameraHeightSize;
        cameraBounds.z = 2 * cameraWidthSize;      // width
        cameraBounds.w = 2 * cameraHeightSize;     // height

        return cameraBounds;
    }
}
