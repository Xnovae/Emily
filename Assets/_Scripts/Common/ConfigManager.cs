using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using ZeroFormatter;

public class ConfigManager
{
    private static ConfigManager _instance;

    public static ConfigManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ConfigManager();
            }

            return _instance;
        }
    }

    private AssetBundle _configAssetBundle;

    private Dictionary<string, object> _dict = new Dictionary<string, object>();

    private ConfigManager()
    { }

    public void Init(AssetBundle configAssetBundle)
    {
        _configAssetBundle = configAssetBundle;
    }

    public T2 GetItem<T1, T2>(string assetName, string id)
        where T1 : ConfigGetItem<T1, T2>, new()
        where T2 : class, new()
    {
        Assert.IsNotNull(_configAssetBundle);

        object itemObj;
        if (_dict.TryGetValue(assetName, out itemObj))
        {
            T1 item = itemObj as T1;
            Assert.IsNotNull(item);

            return item.GetItem(id);
        }
        else
        {
            TextAsset textAsset = _configAssetBundle.LoadAsset<TextAsset>(assetName);
            Assert.IsNotNull(textAsset);

            itemObj = ZeroFormatterSerializer.Deserialize<T1>(textAsset.bytes);
            _dict.Add(assetName, itemObj);

            T1 item = itemObj as T1;
            Assert.IsNotNull(item);

            return item.GetItem(id);
        }
    }
}
