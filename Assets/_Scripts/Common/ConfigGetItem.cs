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

    public object GetJsonDataValue(JsonData data, Type type)
    {
        if (type == typeof(long))
        {
            return (long) data;
        }
        else if (type == typeof(bool))
        {
            return (bool)data;
        }
        else if (type == typeof(float))
        {
            return Convert.ToSingle((double) data);
        }
        else if (type == typeof(int))
        {
            return (int) data;
        }
        else if (type == typeof(string))
        {
            return (string) data;
        }

        // Array
        if (type == typeof(long[]))
        {
            int length = data.Count;
            var value = new long[length];
            for (int i = 0; i < length; ++i)
            {
                value[i] = (long) data[i];
            }
            return value;
        }
        else if (type == typeof(bool[]))
        {
            int length = data.Count;
            var value = new bool[length];
            for (int i = 0; i < length; ++i)
            {
                value[i] = (bool)data[i];
            }
            return value;
        }
        else if (type == typeof(float[]))
        {
            int length = data.Count;
            var value = new float[length];
            for (int i = 0; i < length; ++i)
            {
                value[i] = Convert.ToSingle((double)data[i]); 
            }
            return value;
        }
        else if (type == typeof(int[]))
        {
            int length = data.Count;
            var value = new int[length];
            for (int i = 0; i < length; ++i)
            {
                value[i] = (int)data[i];
            }
            return value;
        }
        else if (type == typeof(string[]))
        {
            int length = data.Count;
            var value = new string[length];
            for (int i = 0; i < length; ++i)
            {
                value[i] = (string)data[i];
            }
            return value;
        }

        // Dictionary
        if (type == typeof(Dictionary<string, long>))
        {
            int length = data.Count;

            var value = new Dictionary<string, long>(length);

            foreach (var item in data)
            {
                var entry = (KeyValuePair<string, JsonData>)item;

                value.Add(entry.Key, (long)entry.Value);
            }

            return value;
        }
        else if (type == typeof(Dictionary<string, bool>))
        {
            int length = data.Count;

            var value = new Dictionary<string, bool>(length);

            foreach (var item in data)
            {
                var entry = (KeyValuePair<string, JsonData>)item;

                value.Add(entry.Key, (bool)entry.Value);
            }

            return value;
        }
        else if (type == typeof(Dictionary<string, float>))
        {
            int length = data.Count;

            var value = new Dictionary<string, float>(length);

            foreach (var item in data)
            {
                var entry = (KeyValuePair<string, JsonData>)item;

                value.Add(entry.Key, Convert.ToSingle((double)entry.Value));
            }

            return value;
        }
        else if (type == typeof(Dictionary<string, int>))
        {
            int length = data.Count;

            var value = new Dictionary<string, int>(length);

            foreach (var item in data)
            {
                var entry = (KeyValuePair<string, JsonData>) item;

                value.Add(entry.Key, (int)entry.Value);
            }

            return value;
        }
        else if (type == typeof(Dictionary<string, string>))
        {
            int length = data.Count;

            var value = new Dictionary<string, string>(length);

            foreach (var item in data)
            {
                var entry = (KeyValuePair<string, JsonData>) item;

                value.Add(entry.Key, (string)entry.Value);
            }

            return value;
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
                SetValue(jsonsKey, item, json);
            }

            byte[] itemBytes = ZeroFormatterSerializer.Serialize<T2>(item);
            dict.Add(key, itemBytes);
        }

        var lazyDictionary = dict.AsLazyDictionary();
        container.SetInternalDictionary(lazyDictionary);

        byte[] containerBytes = ZeroFormatterSerializer.Serialize<T1>(container);
        System.IO.File.WriteAllBytes(outputPath, containerBytes);
    }

    private void SetValue(string jsonsKey, T2 item, JsonData json)
    {
        Type type = GetMemberType<T2>(jsonsKey);

        typeof(T2).InvokeMember(jsonsKey,
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty,
            Type.DefaultBinder, item, new object[] { GetJsonDataValue(json[jsonsKey], type) });
    }

    private Type GetMemberType<T>(string jsonsKey)
    {
        return typeof(T2).GetProperty(jsonsKey).PropertyType;
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
