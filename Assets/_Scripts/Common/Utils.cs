using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Reflection;
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
#if UNITY_TVOS
                case BuildTarget.tvOS:
                    return "tvOS";
#endif
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
#if UNITY_TVOS
                case RuntimePlatform.tvOS:
                    return "tvOS";
#endif
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

    /// <span class="code-SummaryComment"><summary></span>
    /// Executes a shell command synchronously.
    /// <span class="code-SummaryComment"></summary></span>
    /// <span class="code-SummaryComment"><param name="command">string command</param></span>
    /// <span class="code-SummaryComment"><returns>string, as output of the command.</returns></span>
    public static void ExecuteCommandSync(string command)
    {
        try
        {
            // create the ProcessStartInfo using "cmd" as the program to be run,
            // and "/c " as the parameters.
            // Incidentally, /c tells cmd that we want it to execute the command that follows,
            // and then exit.
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo();

#if UNITY_IOS
            procStartInfo.FileName = "/bin/bash";
            procStartInfo.Arguments = "-c \"" + command + "\"";
#else
            procStartInfo.FileName = "cmd.exe";
            procStartInfo.Arguments = "/c " + command;
#endif

            // The following commands are needed to redirect the standard output.
            // This means that it will be redirected to the Process.StandardOutput StreamReader.
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            // Do not create the black window.
            procStartInfo.CreateNoWindow = true;
            // Now we create a process, assign its ProcessStartInfo and start it
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            // Get the output into a string
            string result = proc.StandardOutput.ReadToEnd();
            // Display the command output.
            Debug.Log(result);
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
        }
    }
}
