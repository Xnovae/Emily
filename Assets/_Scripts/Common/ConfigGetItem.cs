using System;
using System.Collections.Generic;
using System.Data.ConstantDatabase;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using LitJson;
using UnityEngine.Assertions;
using ZeroFormatter;

public abstract class ConfigGetItem<T>
    where T : class, new ()
{
    private Dictionary<string, T> _dictionary;

    public Dictionary<string, T> GetDictionary()
    {
        return _dictionary;
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
    public void SerializeObject(CdbWriter cdbWriter, string jsonStr, string outputPath)
    {
        var jsons = JsonMapper.ToObject(jsonStr);

        Dictionary<string, byte[]> dict = new Dictionary<string, byte[]>(jsons.Count);

        foreach (var id in jsons.Keys)
        {
            JsonData json = jsons[id];

            T item = new T();
            foreach (var jsonsKey in json.Keys)
            {
                SetValue(jsonsKey, item, json);
            }

            byte[] itemBytes = ZeroFormatterSerializer.Serialize<T>(item);
            dict.Add(id, itemBytes);
        }

        string assetName = Path.GetFileNameWithoutExtension(outputPath);
        foreach (var item in dict)
        {
            string id = item.Key;
            byte[] key = EncodeKey(assetName, id);
            byte[] value = item.Value;

            cdbWriter.Add(key, value);
        }
    }

    private void SetValue(string jsonsKey, T item, JsonData json)
    {
        Type type = GetMemberType<T>(jsonsKey);

        typeof(T).InvokeMember(jsonsKey,
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty,
            Type.DefaultBinder, item, new object[] { GetJsonDataValue(json[jsonsKey], type) });
    }

    private Type GetMemberType<T2>(string jsonsKey)
    {
        return typeof(T2).GetProperty(jsonsKey).PropertyType;
    }
#endif

    public T GetItem(CdbReader cdbReader, string assetName, string id)
    {
        InitializeDictionary();

        T item;
        if (_dictionary.TryGetValue(id, out item))
        {
            return item;
        }
        else
        {
            byte[] key = EncodeKey(assetName, id);

            byte[] value = cdbReader.Find(key);
            Assert.IsNotNull(value, string.Format("Can not find assetName: {0} id: {1}", assetName, id));

            item = ZeroFormatterSerializer.Deserialize<T>(value);

            _dictionary.Add(id, item);

            return item;
        }
    }

    private void InitializeDictionary()
    {
        if (_dictionary == null)
        {
            _dictionary = new Dictionary<string, T>();
        }
    }

    public static byte[] EncodeKey(string assetName, string id)
    {
        return Encoding.UTF8.GetBytes(assetName + "$$" + id);
    }
}
