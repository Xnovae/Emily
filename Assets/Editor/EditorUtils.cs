using System;
using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using LitJson;
using UnityEngine.Assertions;

using Object = UnityEngine.Object;

public static class EditorUtils
{
    public const string AssetBundlesOutputPath = "AssetBundles";

    public const string DEPENDENCY_JSON_PATH = "Assets/JSONs/EditorOnly-dependency.json";

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

    public static T[] GetAtPath<T>(string path) where T : Object
    {
        path = path.Replace("\\", "/");
        int index = path.IndexOf("Assets/", StringComparison.Ordinal);
        if (index == -1)
            throw new Exception(string.Format("path: {0} not contains Assets/", path));

        path = path.Substring(index);
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

    public static Dictionary<string, string> MergeDictionary(Dictionary<string, string> dict1,
        Dictionary<string, string> dict2)
    {
        var dict = new Dictionary<string, string>(dict1.Count + dict2.Count);

        foreach (var item in dict1)
        {
            dict.Add(item.Key, item.Value);
        }

        foreach (var item in dict2)
        {
            dict.Add(item.Key, item.Value);
        }

        return dict;
    }

    public static string TrimAssetPath(string originPath)
    {
        originPath = originPath.Replace("\\", "/");
        int index = originPath.IndexOf("Assets/", StringComparison.Ordinal);
        if (index == -1)
            throw new Exception(string.Format("originPath {0} not contains Assets/", originPath));

        return originPath.Substring(index);
    }

    public static void CreateAssetBundle(Object[] objs, string subFolder, string assetBundleName)
    {
        string destFolder = string.Format("{0}/{1}", Application.streamingAssetsPath, Utils.GetPlatformName(false));
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

    public static void CreateAssetBundles(Dictionary<string, string> dict)
    {
        string destFolder = string.Format("{0}/{1}", Application.streamingAssetsPath, Utils.GetPlatformName(false));
        if (!Directory.Exists(destFolder))
        {
            Directory.CreateDirectory(destFolder);
        }

        int length = dict.Count;
        AssetBundleBuild[] buildMap = new AssetBundleBuild[length];

        int index = 0;
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

    public static Dictionary<string, string> GetDependency()
    {
        Assert.IsTrue(File.Exists(DEPENDENCY_JSON_PATH));
        string jsonStr = File.ReadAllText(DEPENDENCY_JSON_PATH);
        var jsons = JsonMapper.ToObject(jsonStr);

        var dict = new Dictionary<string, string>();
        for (int i = 0, length = jsons.Count; i < length; ++i)
        {
            var json = jsons[i];
            string assertPath = (string)json["assetsPath"];
            string assetBundlePath = (string)json["assetBundlePath"];

            dict[assertPath] = assetBundlePath;
        }

        return dict;
    }

}
