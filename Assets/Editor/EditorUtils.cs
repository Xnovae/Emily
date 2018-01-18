using System;
using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Assertions;

using Object = UnityEngine.Object;

public static class EditorUtils
{
    public const string AssetBundlesOutputPath = "AssetBundles";

    public static T ParseEnum<T>(string value)
    {
        return (T)Enum.Parse(typeof(T), value, true);
    }

    public static void ChangeShader(string path, string shaderName)
    {
        Material obj = AssetDatabase.LoadAssetAtPath(path, typeof(Material)) as Material;
        Shader shader = Shader.Find(shaderName);

        if (obj != null && shader != null)
        {
            obj.shader = shader;
        }
        else
        {
            Debug.LogErrorFormat("!!! ChangeShader Error, path = {0}, shaderName = {1}", path, shaderName);
        }
    }

    public static void ExecuteCommandSync(object command)
    {
        try
        {
            // create the ProcessStartInfo using "cmd" as the program to be run,
            // and "/c " as the parameters.
            // Incidentally, /c tells cmd that we want it to execute the command that follows,
            // and then exit.
            System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);

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
            if(!string.IsNullOrEmpty(result))
                Debug.LogError(result);
        }
        catch (Exception objException)
        {
            Debug.LogException(objException);
        }
    }

    public static T[] GetAtPath<T>(string path) where T : Object
    {
        path = path.StartsWith("Assets/") ? path : path.Substring(path.IndexOf("Assets/"));
        Assert.IsTrue(path.StartsWith("Assets/"));

        ArrayList al = new ArrayList();
        string[] fileEntries = Directory.GetFiles(path);
        foreach (string fileName in fileEntries)
        {
            T t = AssetDatabase.LoadAssetAtPath<T>(fileName);

            if (t != null)
                al.Add(t);
        }
        T[] result = new T[al.Count];
        for (int i = 0; i < al.Count; i++)
            result[i] = (T)al[i];

        return result;
    }

    public static void CreateAssetBundle(Object[] objs, string subFolder, string assetBundleName)
    {
        string destFolder = string.Format("{0}/{1}", Application.streamingAssetsPath, Utils.GetPlatformName());
        if (!Directory.Exists(destFolder))
        {
            Directory.CreateDirectory(destFolder);
        }

        int length = objs.Length;
        AssetBundleBuild[] buildMap = new AssetBundleBuild[length];

        for (int i = 0; i < length; ++i)
        {
            Object obj = objs[i];

            string sourcePath = AssetDatabase.GetAssetPath(obj);

            if (string.IsNullOrEmpty(assetBundleName))
            {
                buildMap[i].assetBundleName = subFolder + "/" + obj.name + ".assetbundle";
            }
            else
            {
                buildMap[i].assetBundleName = subFolder + "/" + assetBundleName;
            }

            string[] resourcesAssets = new string[1] { sourcePath };
            buildMap[i].assetNames = resourcesAssets;
        }

        BuildPipeline.BuildAssetBundles(destFolder, buildMap, BuildAssetBundleOptions.ChunkBasedCompression | BuildAssetBundleOptions.ForceRebuildAssetBundle | BuildAssetBundleOptions.DeterministicAssetBundle, EditorUserBuildSettings.activeBuildTarget);
    }

    public static void CreateAssetBundleWithDependency(Object[] objs, string subFolder, string assetBundleName, Dictionary<string, string> dict)
    {
        string destFolder = string.Format("{0}/{1}", Application.streamingAssetsPath, Utils.GetPlatformName());
        if (!Directory.Exists(destFolder))
        {
            Directory.CreateDirectory(destFolder);
        }

        int objsLength = objs.Length;
        int dependencyLength = dict.Count;

        AssetBundleBuild[] buildMap = new AssetBundleBuild[objsLength + dependencyLength];

        for (int i = 0; i < objsLength; ++i)
        {
            Object obj = objs[i];

            string sourcePath = AssetDatabase.GetAssetPath(obj);

            if (string.IsNullOrEmpty(assetBundleName))
            {
                buildMap[i].assetBundleName = subFolder + "/" + obj.name + ".assetbundle";
            }
            else
            {
                buildMap[i].assetBundleName = subFolder + "/" + assetBundleName;
            }

            string[] resourcesAssets = new string[1] { sourcePath };
            buildMap[i].assetNames = resourcesAssets;
        }

        int index = objsLength;
        var enumrator = dict.GetEnumerator();
        while (enumrator.MoveNext())
        {
            string sourcePath = enumrator.Current.Key;
            string[] resourcesAssets = new string[1] { sourcePath };
            buildMap[index].assetNames = resourcesAssets;

            string bundleName = enumrator.Current.Value;
            buildMap[index].assetBundleName = bundleName;

            ++index;
        }

        enumrator.Dispose();

        BuildPipeline.BuildAssetBundles(destFolder, buildMap, BuildAssetBundleOptions.ChunkBasedCompression | BuildAssetBundleOptions.ForceRebuildAssetBundle | BuildAssetBundleOptions.DeterministicAssetBundle, EditorUserBuildSettings.activeBuildTarget);
    }
}
