using System.Collections;
using System.Collections.Generic;
using System.Data.ConstantDatabase;
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

    private CdbReader _cdbReader;

    private Dictionary<string, object> _dict = new Dictionary<string, object>();

    private ConfigManager()
    { }

    public void Init(string cdbPath)
    {
        _cdbReader = new CdbReader(cdbPath);
    }

    public CdbReader GetCdbReader()
    {
        return _cdbReader;
    }

    public void Close()
    {
        if (_cdbReader != null)
        {
            _cdbReader.Close();
        }
    }

    public T GetItem<T>(string assetName, string id)
        where  T : ConfigGetItem<T>, new()
    {
        object itemObj;
        if (_dict.TryGetValue(assetName, out itemObj))
        {
            var item = itemObj as T;
            Assert.IsNotNull(item);

            return item.GetItem(assetName, id);
        }
        else
        {
            var item = new T();

            _dict.Add(assetName, item);

            return item.GetItem(assetName, id);

            //TextAsset textAsset = _configAssetBundle.LoadAsset<TextAsset>(assetName);
            //Assert.IsNotNull(textAsset);

            //itemObj = ZeroFormatterSerializer.Deserialize<>(textAsset.bytes);
            //_dict.Add(assetName, itemObj);

            // item = itemObj as ;
            //Assert.IsNotNull(item);

            //return item.GetItem(id);
        }
    }
}
