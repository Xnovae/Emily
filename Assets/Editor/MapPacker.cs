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

    public const string DEPENDENCY_JSON_PATH = "Assets/JSONs/EditorOnly-dependency.json";

    public const int MAP_WIDTH = 512;
    public const int MAP_HEIGHT = 512;

    [MenuItem("EditorTools/Map Packer")]
    private static void MenuItem_MapPacker()
    {
        var window = GetWindow<EditorMapPacker>("Map Packer");
        window.Show();
    }

    private string _mapPath = "Assets/Temp/Map/map.tga";
    private string _slicePath = "Assets/Temp/Map_Slicer/town/";
    private string _collectionPath = "Assets/Temp/Map_Collection/town/";

    private void OnGUI()
    {
        // 图片 切片放哪 图集放哪？
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
            SliceMap(_mapPath, MAP_WIDTH, MAP_HEIGHT, _slicePath);
            AssetDatabase.Refresh();
        }

        if(GUILayout.Button("Gen Collection"))
        {
            GenCollection(_slicePath, _collectionPath);
            AssetDatabase.Refresh();
        }

        this.Repaint();
    }

    private void GenCollection(string slicePath, string collectionPath)
    {
        if(Directory.Exists(collectionPath))
        {
            Directory.Delete(collectionPath, true);
        }
        Directory.CreateDirectory(collectionPath);
        AssetDatabase.Refresh();

        Texture2D[] textures = EditorUtils.GetAtPath<Texture2D>(_slicePath);

        int length = textures.Length;
        Object[] packageCollections = new Object[length];
        for(int i=0; i<length; ++i)
        {
            Texture2D texture = textures[i];
            var collection = GenCollectionInternal(collectionPath, texture);

            packageCollections[i] = PackageAssetBundle(collection);
        }

        // 打包
        var dependency = GetDependency();

        string mapFolder = "map/" + new DirectoryInfo(slicePath).Name;
        EditorUtils.CreateAssetBundleWithDependency(packageCollections, mapFolder, null, dependency);

        AssetDatabase.Refresh();
    }

    private Dictionary<string, string> GetDependency()
    {
        Assert.IsTrue(File.Exists(DEPENDENCY_JSON_PATH));
        string jsonStr = File.ReadAllText(DEPENDENCY_JSON_PATH);
        var jsons = JsonMapper.ToObject(jsonStr);

        var dict = new Dictionary<string, string>();
        for (int i=0, length = jsons.Count; i<length; ++i)
        {
            var json = jsons[i];
            string assertPath = (string) json["assetsPath"];
            string assetBundlePath = (string) json["assetBundlePath"];

            dict[assertPath] = assetBundlePath;
        }

        return dict;
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

    private Object PackageAssetBundle(tk2dSpriteCollection collection)
    {
        string fullPath = AssetDatabase.GetAssetPath(collection);

        string parentDir = Path.GetDirectoryName(fullPath);
        string nameWidthoutExt = Path.GetFileNameWithoutExtension(fullPath);

        string collectionPath = string.Format("{0}/{1} Data/{2}.prefab", parentDir, nameWidthoutExt, nameWidthoutExt);

        Object obj = AssetDatabase.LoadAssetAtPath<Object>(collectionPath);

        return obj;
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

    private void SliceMap(string mapPath, int mapWidth, int mapHeight, string slicePath)
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
