using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using LitJson;
using UnityEngine.Assertions;

using Object = UnityEngine.Object;

public partial class tk2dSpriteCollectionEditorPopup
{
    public void PackMap(Object[] objs)
    {
        HandleDroppedPayload(objs);

        spriteCollectionProxy.DeleteUnusedData();
        spriteCollectionProxy.CopyToTarget();
        tk2dSpriteCollectionBuilder.ResetCurrentBuild();

        foreach (var t in _spriteCollection.textureParams)
        {
            t.anchor = tk2dSpriteCollectionDefinition.Anchor.LowerLeft;
        }

        if (!tk2dSpriteCollectionBuilder.Rebuild(_spriteCollection))
        {
            EditorUtility.DisplayDialog("Failed to commit sprite collection",
                "Please check the console for more details.", "Ok");
        }
        spriteCollectionProxy.CopyFromSource();
    }
}

public class EditorMapPacker : EditorWindow
{
    public const string PYTHON_SLICER = "Assets/Editor/Tools/MapSlicer.py";

    public const string TK2D_MAP_SHADER = "tk2d/Map";

    public const int MAP_WIDTH = 512;
    public const int MAP_HEIGHT = 512;

    [MenuItem("EditorTools/Map/Map Packer")]
    private static void MenuItem_MapPacker()
    {
        var window = GetWindow<EditorMapPacker>("Map Packer");
        window.Show();
    }

    private string _mapPath = "Assets/Temp/Map/";
    private string _slicePath = "Assets/Temp/Map_Slicer/";
    private string _collectionPath = "Assets/Temp/Map_Collection/";

    private void OnGUI()
    {
        string mapPath = EditorGUILayout.TextField("map path: ", _mapPath);
        if(mapPath != _mapPath)
        {
            var texture = AssetDatabase.LoadAssetAtPath<Texture>(mapPath);
            if(texture)
            {
                _mapPath = mapPath;
            }
        }

        string slicePath = EditorGUILayout.TextField("slice path: ", _slicePath);
        if(slicePath != _slicePath)
        {
            _slicePath = slicePath.EndsWith("/") ? slicePath : slicePath + "/";
        }

        string collectionPath = EditorGUILayout.TextField("collection path: ", _collectionPath);
        if(collectionPath != _collectionPath)
        {
            _collectionPath = collectionPath.EndsWith("/") ? collectionPath : collectionPath + "/";
        }

        if(GUILayout.Button("Slice Map"))
        {
            SliceMap();

            AssetDatabase.Refresh();
        }

        if(GUILayout.Button("Gen Collection"))
        {
            GenCollection();

            AssetDatabase.Refresh();
        }

        if (GUILayout.Button("Build AssetBundle"))
        {
            BuildAssetBundle();

            AssetDatabase.Refresh();
        }

        this.Repaint();
    }

    private void GenCollection()
    {
        if (Directory.Exists(_collectionPath))
        {
            Directory.Delete(_collectionPath, true);
        }
        Directory.CreateDirectory(_collectionPath);
        AssetDatabase.Refresh();

        var directoryInfo = new DirectoryInfo(_slicePath);
        foreach (var directory in directoryInfo.GetDirectories("*", SearchOption.TopDirectoryOnly))
        {
            string mapName = directory.Name;

            GenCollectionInternal(_slicePath + mapName + "/", _collectionPath + mapName + "/");
        }
    }

    private void SliceMap()
    {
        Texture2D[] textures = EditorUtils.GetAtPath<Texture2D>(_mapPath);

        foreach (var texture in textures)
        {
            string path = AssetDatabase.GetAssetPath(texture);
            string assetPath = EditorUtils.TrimAssetPath(path);

            SliceMapInternal(assetPath, MAP_WIDTH, MAP_HEIGHT, _slicePath + texture.name + "/");
        }
    }

    private void BuildAssetBundle()
    {
        var directoryInfo = new DirectoryInfo(_collectionPath);

        Dictionary<string, string> mapDict = new Dictionary<string, string>();

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

        // 打包
        var dependencyDict = EditorUtils.GetDependency();

        var dict = EditorUtils.MergeDictionary(mapDict, dependencyDict);

        EditorUtils.CreateAssetBundles(dict);
    }

    private void GenCollectionInternal(string slicePath, string collectionPath)
    {
        if (!Directory.Exists(collectionPath))
        {
            Directory.CreateDirectory(collectionPath);
        }

        Texture2D[] textures = EditorUtils.GetAtPath<Texture2D>(slicePath);
        foreach (var texture in textures)
        {
            GenCollectionInternal(collectionPath, texture);
        }
    }

    
    private tk2dSpriteCollection GenCollectionInternal(string collectionPath, Texture2D texture)
    {
        // 生成 tk2d prefab
        var collection = GenerateTk2dPrefab(collectionPath, texture);

        // 生成图集
        PackTextureToCollection(collection, texture);

        // 更改shader
        ChangeShader(collection);

        return collection;
    }

    private void ChangeShader(tk2dSpriteCollection collection)
    {
        string fullPath = AssetDatabase.GetAssetPath(collection);

        string parentDir = Path.GetDirectoryName(fullPath);
        string nameWidthoutExt = Path.GetFileNameWithoutExtension(fullPath);

        string materialPath = string.Format("{0}/{1} Data/atlas0 material.mat", parentDir, nameWidthoutExt);
        EditorUtils.ChangeShader(materialPath, TK2D_MAP_SHADER);

        AssetDatabase.Refresh();
    }

    private void PackTextureToCollection(tk2dSpriteCollection collection, Texture2D texture)
    {
        var gen = collection;
        gen.padAmount = 0;

        tk2dSpriteCollectionEditorPopup v = ScriptableObject.CreateInstance<tk2dSpriteCollectionEditorPopup>();
        v.SetGenerator(gen);

        Object[] objs = new Object[1] { texture };

        v.PackMap(objs);

        AssetDatabase.Refresh();
    }

    private tk2dSpriteCollection GenerateTk2dPrefab(string collectionPath, Texture2D texture)
    {
        string basePath = collectionPath.EndsWith("/") ? collectionPath.Substring(0, collectionPath.Length - 1) : collectionPath;

        return tk2dSpriteCollectionEditor.CreateSpriteCollection(basePath, texture.name);
    }

    private void SliceMapInternal(string mapPath, int mapWidth, int mapHeight, string slicePath)
    {
        Assert.IsNotNull(mapPath);
        Assert.IsNotNull(slicePath);

        Assert.IsTrue(File.Exists(mapPath));

        if(Directory.Exists(slicePath))
        {
            Directory.Delete(slicePath, true);
        }
        Directory.CreateDirectory(slicePath);
        AssetDatabase.Refresh();

        string commandFormat = "python {0} {1} {2} {3} {4}";
        string command = string.Format(commandFormat, PYTHON_SLICER, mapPath, mapWidth, mapHeight, slicePath);

        EditorUtils.ExecuteCommandSync(command);
    }
}
