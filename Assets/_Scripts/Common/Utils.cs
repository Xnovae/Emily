using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Reflection;
using UnityEngine.Assertions;
#if UNITY_EDITOR
using UnityEditor;
#endif

public static class Utils
{
    public static string GetBundlePathForLoadFromFile(string relativePath)
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        var streamingAssetsPath = Application.dataPath + "!assets/";
#else
        var streamingAssetsPath = Application.streamingAssetsPath;
#endif

        return Path.Combine(streamingAssetsPath, GetPlatformName() + "/" + relativePath);
    }

    public static AssetBundle LoadBundleFromStreamingAssets(string relativePath)
    {
        return AssetBundle.LoadFromFile(GetBundlePathForLoadFromFile(relativePath));
    }

    public static string GetPlatformName()
    {
#if UNITY_EDITOR
        return GetPlatformForAssetBundles(EditorUserBuildSettings.activeBuildTarget);
#else
        return GetPlatformForAssetBundles(Application.platform);
#endif
    }

#if UNITY_EDITOR
    private static string GetPlatformForAssetBundles(BuildTarget target)
    {
        switch (target)
        {
            case BuildTarget.Android:
                return "Android";
            case BuildTarget.tvOS:
                return "tvOS";
            case BuildTarget.iOS:
                return "iOS";
            case BuildTarget.WebGL:
                return "WebGL";
            case BuildTarget.StandaloneWindows:
            case BuildTarget.StandaloneWindows64:
                return "Windows";
            case BuildTarget.StandaloneOSX:
                return "OSX";
            // Add more build targets for your own.
            // If you add more targets, don't forget to add the same platforms to GetPlatformForAssetBundles(RuntimePlatform) function.
            default:
                return null;
        }
    }
#endif

    private static string GetPlatformForAssetBundles(RuntimePlatform platform)
    {
        switch (platform)
        {
            case RuntimePlatform.Android:
                return "Android";
            case RuntimePlatform.IPhonePlayer:
                return "iOS";
            case RuntimePlatform.tvOS:
                return "tvOS";
            case RuntimePlatform.WebGLPlayer:
                return "WebGL";
            case RuntimePlatform.WindowsPlayer:
                return "Windows";
            case RuntimePlatform.OSXPlayer:
                return "OSX";
            // Add more build targets for your own.
            // If you add more targets, don't forget to add the same platforms to GetPlatformForAssetBundles(RuntimePlatform) function.
            default:
                return null;
        }
    }

    public static Type NameToType(string name)
    {
        foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            Type type = assembly.GetType(name);

            if (type != null)
                return type;
        }

        return null;
    }

    public static Vector2 ScreenToLogicPosition(Camera camera, Vector2 screenPosition)
    {
        Vector3 cameraPosition = camera.transform.position;


        float cameraHeightSize = camera.orthographicSize;
        float cameraWidthSize = camera.aspect * cameraHeightSize;

        Vector4 cameraBounds = new Vector4();

        cameraBounds.x = cameraPosition.x - cameraWidthSize;
        cameraBounds.y = cameraPosition.y - cameraHeightSize;
        cameraBounds.z = 2 * cameraWidthSize;      // width
        cameraBounds.w = 2 * cameraHeightSize;     // height

        return new Vector2(cameraBounds.x + cameraBounds.z * screenPosition.x,
            cameraBounds.y + cameraBounds.w * screenPosition.y);
    }

    public static CharacterDirection GetCharacterDirection(float x, float y)
    {
        if (x > 0.0f)
        {
            return CharacterDirection.Right;
        }
        else if (x < 0.0f)
        {
            return CharacterDirection.Left;
        }
        else
        {
            return CharacterDirection.None;
        }
    }
}
