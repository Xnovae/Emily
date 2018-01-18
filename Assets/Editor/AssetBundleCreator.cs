using System;
using UnityEditor;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Object = UnityEngine.Object;

public class AssetBundleCreator
{
    [MenuItem("EditorTools/Create - AssetBundles")]
    public static void CreateAssetBunldesMain()
    {
        Object[] selectedAssets = Selection.GetFiltered(typeof(Object), SelectionMode.Assets | SelectionMode.DeepAssets);
        if (selectedAssets == null || selectedAssets.Length == 0)
            return;

        EditorUtils.CreateAssetBundle(selectedAssets, "Temp", null);

        //刷新编辑器
        AssetDatabase.Refresh();
    }
}
