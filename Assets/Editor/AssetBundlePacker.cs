using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class AssetBundlePacker : EditorWindow
{
    public static readonly string Directory_Map = "Assets/Temp/Map_Collection/";
    public static readonly string Directory_Character = "Assets/_SpriteCollection";

    [MenuItem("EditorTools/Build/Pack AssetBundles")]
    private static void MenuItem_MapPacker()
    {
        var window = GetWindow<AssetBundlePacker>("AssetBundle Packer");
        window.Show();
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Pack AssetBundles"))
        {
            PackAssetBundles();

            AssetDatabase.Refresh();
        }
    }

    private void PackAssetBundles()
    {
        var mapDict = GetMapDict();
        var characterDict = GetCharacterDict();
        var dependencyDict = EditorUtils.GetDependency();

        var result = EditorUtils.MergeDictionary(mapDict, characterDict);
        result = EditorUtils.MergeDictionary(result, dependencyDict);

        EditorUtils.CreateAssetBundles(result);

        AssetDatabase.Refresh();

        // finally rename AssetBundleManifest
        string format = "{0}/{1}/{2}";
        string oldName = string.Format(format, Application.streamingAssetsPath, Utils.GetPlatformName(false),
            Utils.GetPlatformName(false));
        string newName = "AssetBundleManifest";
        AssetDatabase.RenameAsset(EditorUtils.TrimAssetPath(oldName), newName);

        string manifestFormat = "{0}/{1}/{2}.manifest";
        string oldManifestName = string.Format(manifestFormat, Application.streamingAssetsPath, Utils.GetPlatformName(false),
            Utils.GetPlatformName(false));
        string newManifestName = "AssetBundleManifest.manifest";
        AssetDatabase.RenameAsset(EditorUtils.TrimAssetPath(oldManifestName), newManifestName);
    }

    private Dictionary<string, string> GetMapDict()
    {
        Dictionary<string, string> mapDict = new Dictionary<string, string>();

        var directoryInfo = new DirectoryInfo(Directory_Map);

        var directories = directoryInfo.GetDirectories("*", SearchOption.TopDirectoryOnly);
        foreach (var directory in directories)
        {
            foreach (var fileInfo in directory.GetFiles("*.prefab", SearchOption.TopDirectoryOnly))
            {
                string fileName = Path.GetFileNameWithoutExtension(fileInfo.Name);
                string dataPath = string.Format("{0}/{1} Data/{2}.prefab", fileInfo.DirectoryName, fileName, fileName);

                string assetPath = EditorUtils.TrimAssetPath(dataPath);
                string assetBundleName = string.Format("map/{0}/{1}.assetbundle", directory.Name, fileName);

                mapDict.Add(assetPath, assetBundleName);
            }
        }

        return mapDict;
    }

    private Dictionary<string, string> GetCharacterDict()
    {
        Dictionary<string, string> characterDict = new Dictionary<string, string>();

        var directoryInfo = new DirectoryInfo(Directory_Character);

        foreach (var fileInfo in directoryInfo.GetFiles("*.prefab", SearchOption.TopDirectoryOnly))
        {
            string fileName = Path.GetFileNameWithoutExtension(fileInfo.Name);
            string dataPath = string.Format("{0}/{1} Data/{2}.prefab", fileInfo.DirectoryName, fileName, fileName);

            string assetPath = EditorUtils.TrimAssetPath(dataPath);
            string assetBundleName = string.Format("character/{0}.assetbundle", fileName);

            characterDict.Add(assetPath, assetBundleName);
        }

        return characterDict;
    }
}
