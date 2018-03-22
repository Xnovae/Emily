using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEditor.Build;

[InitializeOnLoad]
public class Startup
{
    static Startup()
    {
        CompileSpeedUpEditor.SetupAssembly();
    }
}

public class ActiveBuildTargetListener : IActiveBuildTargetChanged
{
    public int callbackOrder { get { return 0; } }

    public void OnActiveBuildTargetChanged(BuildTarget previousTarget, BuildTarget newTarget)
    {
        CompileSpeedUpEditor.SetupAssembly();
    }
}

public static class CompileSpeedUpEditor
{
    public static readonly string asf_3rd_source = "Assets/Editor/CompileSpeedUp/3rd_party.asmdef.bytes";
    public static readonly string asf_3rd_dest = "Assets/3rd_party/3rd_party.asmdef";

    public static readonly string asf_emily_source = "Assets/Editor/CompileSpeedUp/Emily.asmdef.bytes";
    public static readonly string asf_emily_dest = "Assets/Emily.asmdef";

    private static bool IsASMFExists()
    {
        return File.Exists(asf_3rd_dest) && File.Exists(asf_emily_dest);
    }

    public static void SetupAssembly()
    {
        if (EditorUserBuildSettings.activeBuildTarget == BuildTarget.StandaloneWindows ||
            EditorUserBuildSettings.activeBuildTarget == BuildTarget.StandaloneWindows64)
        {
            MenuItem_EnableSpeedUp();
        }
        else
        {
            MenuItem_DisableSpeedUp();
        }

        AssetDatabase.Refresh();
    }

    [MenuItem("EditorTools/SpeedUp/Enable")]
    public static void MenuItem_EnableSpeedUp()
    {
        // 拷贝两个文件
        if (!File.Exists(asf_3rd_dest))
        {
            FileUtil.CopyFileOrDirectory(asf_3rd_source, asf_3rd_dest);
        }
        if (!File.Exists(asf_emily_dest))
        {
            FileUtil.CopyFileOrDirectory(asf_emily_source, asf_emily_dest);
        }

        // 刷新
        AssetDatabase.Refresh();
    }

    [MenuItem("EditorTools/SpeedUp/Enable", true)]
    private static bool MenuItem_EnableSpeedUpValidation()
    {
        return !IsASMFExists();
    }

    [MenuItem("EditorTools/SpeedUp/Disable")]
    public static void MenuItem_DisableSpeedUp()
    {
        // 删除两个文件
        FileUtil.DeleteFileOrDirectory(asf_3rd_dest);
        FileUtil.DeleteFileOrDirectory(asf_emily_dest);

        // 刷新
        AssetDatabase.Refresh();
    }

    [MenuItem("EditorTools/SpeedUp/Disable", true)]
    private static bool MenuItem_DisableSpeedUpValidation()
    {
        return IsASMFExists();
    }
}
