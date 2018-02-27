using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CameraLoadingBounds : MonoBehaviour
{
    public Vector4 LoadingOffset = new Vector4(5.12f, 5.12f, 5.12f, 5.12f);  // up x; left y; down z; left w

    private Camera _camera;

    void Awake()
    {
        _camera = GetComponent<Camera>();
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;

        var aspect = _camera.aspect;    // width / height

        float sizeHeight = _camera.orthographicSize;
        float sizeWidth = sizeHeight * aspect;

        Vector3 position = _camera.transform.position;

        Vector3 leftTop = new Vector3(position.x - 1 * sizeWidth, position.y + 1 * sizeHeight, position.z);
        Vector3 rightTop = new Vector3(leftTop.x + 2 * sizeWidth, leftTop.y, leftTop.z);
        Vector3 leftBottom = new Vector3(leftTop.x, position.y - 1 * sizeHeight, position.z);
        Vector3 rightBottom = new Vector3(leftBottom.x + 2 * sizeWidth, leftBottom.y, leftBottom.z);

        leftTop.y += LoadingOffset.x >= 0.0f ? LoadingOffset.x : 0.0f;
        rightTop.y += LoadingOffset.x >= 0.0f ? LoadingOffset.x : 0.0f;

        rightTop.x += LoadingOffset.y >= 0.0f ? LoadingOffset.y : 0.0f;
        rightBottom.x += LoadingOffset.y >= 0.0f ? LoadingOffset.y : 0.0f;

        leftBottom.y -= LoadingOffset.z >= 0.0f ? LoadingOffset.z : 0.0f;
        rightBottom.y -= LoadingOffset.z >= 0.0f ? LoadingOffset.z : 0.0f;

        leftTop.x -= LoadingOffset.w >= 0.0f ? LoadingOffset.w : 0.0f;
        leftBottom.x -= LoadingOffset.w >= 0.0f ? LoadingOffset.w : 0.0f;

        Gizmos.DrawLine(leftTop, rightTop);
        Gizmos.DrawLine(leftTop, leftBottom);
        Gizmos.DrawLine(leftBottom, rightBottom);
        Gizmos.DrawLine(rightTop, rightBottom);
    }
}
