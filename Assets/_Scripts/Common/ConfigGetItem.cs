using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using LitJson;
using UnityEngine.Assertions;
using ZeroFormatter;

public abstract class ConfigGetItem<T1, T2>
    where T1 : ConfigGetItem<T1, T2>, new ()
    where T2 : class, new ()
{
    protected abstract ILazyDictionary<string, byte[]> GetInternalDictionary();
    protected abstract void SetInternalDictionary(ILazyDictionary<string, byte[]> dictionary);

    private Dictionary<string, T2> _dictionary;

    public Dictionary<string, T2> GetDictionary()
    {
        return _dictionary;
    }

    public void LoadAll()
    {
        var internalDictionary = GetInternalDictionary();

        int length = internalDictionary.Count;
        if (length > 0)
        {
            string[] keys = new string[length];
            int index = 0;

            foreach (var item in internalDictionary)
            {
                keys[index] = item.Key;
                ++index;
            }

            for(int i=0; i<length; ++i)
            {
                GetItem(keys[i]);
            }
        }
    }

    public object GetJsonDataValue(JsonData data)
    {
        if (data.IsLong)
        {
            return (long) data;
        }
        else if (data.IsBoolean)
        {
            return (bool)data;
        }
        else if (data.IsDouble)
        {
            return Convert.ToSingle((double) data);
        }
        else if (data.IsInt)
        {
            return (int) data;
        }
        else if (data.IsString)
        {
            return (string) data;
        }
        else
        {
            return null;
        }
    }

#if UNITY_EDITOR
    public void SerializeObject(string jsonStr, string outputPath)
    {
        var jsons = JsonMapper.ToObject(jsonStr);

        T1 container = new T1();
        Dictionary<string, byte[]> dict = new Dictionary<string, byte[]>(jsons.Count);

        foreach (var key in jsons.Keys)
        {
            JsonData json = jsons[key];

            T2 item = new T2();
            foreach (var jsonsKey in json.Keys)
            {
                typeof(T2).InvokeMember(jsonsKey,
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty,
                    Type.DefaultBinder, item, new object[]{GetJsonDataValue(json[jsonsKey])});
            }

            byte[] itemBytes = ZeroFormatterSerializer.Serialize<T2>(item);
            dict.Add(key, itemBytes);
        }

        var lazyDictionary = dict.AsLazyDictionary();
        container.SetInternalDictionary(lazyDictionary);

        byte[] containerBytes = ZeroFormatterSerializer.Serialize<T1>(container);
        System.IO.File.WriteAllBytes(outputPath, containerBytes);
    }
#endif

    public T2 GetItem(string key)
    {
        var internalDictionary = GetInternalDictionary();
        Assert.IsNotNull(internalDictionary);

        InitializeDictionary();

        T2 item;
        if (_dictionary.TryGetValue(key, out item))
        {
            return item;
        }
        else
        {
            byte[] bytes;
            if (internalDictionary.TryGetValue(key, out bytes))
            {
                item = ZeroFormatterSerializer.Deserialize<T2>(bytes);

                _dictionary.Add(key, item);
                internalDictionary.Remove(key);    // free bytes

                return item;
            }
            else
            {
                UnityEngine.Debug.LogWarning("!!! config Achievement cannot find: " + key);
                return null;
            }
        }
    }

    private void InitializeDictionary()
    {
        var internalDictionary = GetInternalDictionary();

        if (_dictionary == null)
        {
            int length = internalDictionary.Count;
            _dictionary = new Dictionary<string, T2>(length);
        }
    }
}
