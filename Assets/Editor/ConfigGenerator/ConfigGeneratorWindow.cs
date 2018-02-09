using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.ConstantDatabase;
using System.IO;
using System.Reflection;
using System.Text;
using LitJson;
using UnityEngine;
using UnityEditor;
using UnityEngine.Assertions;
using Object = UnityEngine.Object;

//// zfc.exe -i D:\Project\Unity\OptimizeConfig\OptimizeConfig.csproj -o "ZeroFormatterGenerated.cs"
public class ColumDefine
{
    public string name;
    public Type type;
}

public class ConfigGeneratorWindow : EditorWindow
{
    [MenuItem("EditorTools/Generate Config")]
    private static void MenuItem_GenerateConfig()
    {
        ConfigGeneratorWindow.ShowWindow();
    }

    public static ConfigGeneratorWindow Instance;

    private static void ShowWindow()
    {
        Instance = EditorWindow.GetWindow<ConfigGeneratorWindow>();
        Instance.titleContent = new GUIContent("Generate Config");
    }

    private Dictionary<ZeroFormatterBuildStage.Stage, Action> _callbackDictionary;

    void Awake()
    {
        ClearStage();
    }

    void OnEnable()
    {
        InitCallbacks();
    }

    private void InitCallbacks()
    {
        _callbackDictionary = new Dictionary<ZeroFormatterBuildStage.Stage, Action>();
        _callbackDictionary.Add(ZeroFormatterBuildStage.Stage.TriggerBuild, BuildStageTriggerBuild);
        _callbackDictionary.Add(ZeroFormatterBuildStage.Stage.GenerateClassFiles, BuildStageGenerateClassFile);
        _callbackDictionary.Add(ZeroFormatterBuildStage.Stage.GenerateZeroFormatter, BuildStageGenerateZeroFormatter);
        _callbackDictionary.Add(ZeroFormatterBuildStage.Stage.GenerateBytes, BuildStageGenerateBytes);
        _callbackDictionary.Add(ZeroFormatterBuildStage.Stage.CreateAssetBundle, BuildStageCreateAssetBundle);
    }

    void Update()
    {
        if (IsBuildRunnging())
        {
            if (EditorApplication.isCompiling || EditorApplication.isUpdating)
                return;

            ZeroFormatterBuildStage.Stage stage = GetBuildStage();

            try
            {
                _callbackDictionary[stage]();
            }
            catch (Exception e)
            {
                string errorMessage = string.Format("!!! Build Error stage: {0}, error: {1}", stage, e);

                Debug.LogErrorFormat(errorMessage);

                ClearStage();
            }
        }
    }

    private void BuildStageTriggerBuild()
    {
        // Debug.Log("!!! BuildStageTriggerBuild");
        string cdbSourcePath = Application.streamingAssetsPath + "/config.cdb";
        if (File.Exists(cdbSourcePath))
        {
            File.Delete(cdbSourcePath);
        }

        string cdbDestPath = Application.persistentDataPath + "/config.cdb";
        if (File.Exists(cdbDestPath))
        {
            File.Delete(cdbDestPath);
        }

        if (File.Exists(ZeroFormatClassPath))
        {
            File.Delete(ZeroFormatClassPath);
        }

        AssetDatabase.Refresh();
        SetStage(ZeroFormatterBuildStage.Stage.GenerateClassFiles);
    }

    private void BuildStageGenerateClassFile()
    {
        // Debug.Log("!!! BuildStageGenerateClassFile");

        GenerateClassFile();

        AssetDatabase.Refresh();
        SetStage(ZeroFormatterBuildStage.Stage.GenerateZeroFormatter);
    }


    private void BuildStageGenerateZeroFormatter()
    {
        // Debug.Log("!!! BuildStageGenerateZeroFormatter");

        GenerateZeroFomatter();

        AssetDatabase.Refresh();
        SetStage(ZeroFormatterBuildStage.Stage.GenerateBytes);
    }

    private void BuildStageGenerateBytes()
    {
        // Debug.Log("!!! BuildStageGenerateBytes");

        GenerateBytes();
        
        AssetDatabase.Refresh();
        SetStage(ZeroFormatterBuildStage.Stage.CreateAssetBundle);
    }

    private void BuildStageCreateAssetBundle()
    {
        // Debug.Log("!!! BuildStageCreateAssetBundle");

        // CDB does not Need AssetBundle
        // CreateAssetBundle();

        AssetDatabase.Refresh();
        ClearStage();

        Debug.Log("!!! Config Generate Finished");
    }

    void OnGUI()
    {
        DrawBuildButton();
    }

    private void DrawBuildButton()
    {
        bool buildPressed = GUILayout.Button("Generate");
        if (buildPressed)
        {
            SetStage(ZeroFormatterBuildStage.Stage.TriggerBuild);
        }
    }

    private void ClearStage()
    {
        EditorPrefs.DeleteKey(ZeroFormatterBuildStage.ZERO_FORMATTER_BUILD_STAGE_RUNNING);
        EditorPrefs.DeleteKey(ZeroFormatterBuildStage.ZERO_FORMATTER_BUILD_STAGE_IDENTIFIER);
    }

    private bool IsBuildRunnging()
    {
        return EditorPrefs.GetBool(ZeroFormatterBuildStage.ZERO_FORMATTER_BUILD_STAGE_RUNNING, false);
    }

    private void SetBuildRunning(bool running)
    {
        EditorPrefs.SetBool(ZeroFormatterBuildStage.ZERO_FORMATTER_BUILD_STAGE_RUNNING, running);
    }

    private ZeroFormatterBuildStage.Stage GetBuildStage()
    {
        string stageStr = EditorPrefs.GetString(ZeroFormatterBuildStage.ZERO_FORMATTER_BUILD_STAGE_IDENTIFIER, "None");

        var stage = GetEnum<ZeroFormatterBuildStage.Stage>(stageStr);
        return stage;
    }

    private void SetStage(ZeroFormatterBuildStage.Stage stage)
    {
        SetBuildRunning(true);
        EditorPrefs.SetString(ZeroFormatterBuildStage.ZERO_FORMATTER_BUILD_STAGE_IDENTIFIER, stage.ToString());
    }

    public static T GetEnum<T>(string name)
    {
        T result = (T)System.Enum.Parse(typeof(T), name);

        return result;
    }

    private static float DoubleToFloat(double value)
    {
        return System.Convert.ToSingle(value);
    }

    private static string TypeToString(Type type)
    {
        if (type == typeof(bool))
        {
            return "bool";
        }
        else if (type == typeof(float))
        {
            return "float";
        }
        else if (type == typeof(int))
        {
            return "int";
        }
        else if (type == typeof(long))
        {
            return "long";
        }
        else if (type == typeof(string))
        {
            return "string";
        }

        // Array
        else if (type == typeof(bool[]))
        {
            return "bool[]";
        }
        else if (type == typeof(float[]))
        {
            return "float[]";
        }
        else if (type == typeof(int[]))
        {
            return "int[]";
        }
        else if (type == typeof(long[]))
        {
            return "long[]";
        }
        else if (type == typeof(string[]))
        {
            return "string[]";
        }

        // Dictionary
        else if (type == typeof(Dictionary<string, bool>))
        {
            return "Dictionary<string, bool>";
        }
        else if (type == typeof(Dictionary<string, float>))
        {
            return "Dictionary<string, float>";
        }
        else if (type == typeof(Dictionary<string, int>))
        {
            return "Dictionary<string, int>";
        }
        else if (type == typeof(Dictionary<string, long>))
        {
            return "Dictionary<string, long>";
        }
        else if (type == typeof(Dictionary<string, string>))
        {
            return "Dictionary<string, string>";
        }

        return null;
    }

    private static Type GetJsonDataType(JsonData data)
    {
        if (data == null)
        {
            return typeof(string);
        }
        else if (data.IsArray)
        {
            int length = data.Count;
            if (length == 0)
            {
                // [] -> string[]
                return typeof(string[]);
            }

            Type firstType = GetSimpleJsonDataType(data[0]);
            bool isFloat = false;

            for (int i = 1; i < length; ++i)
            {
                Type type = GetSimpleJsonDataType(data[i]);
                if (type != firstType)
                {
                    if ((firstType == typeof(int) || firstType == typeof(long)) && type == typeof(float))
                    {
                        isFloat = true;
                        continue;
                    }

                    throw new Exception("!!! error Array type not the same");
                }
            }

            return isFloat ? typeof(float[]) : firstType.MakeArrayType();
        }
        else if (data.IsObject)
        {
            int length = data.Count;
            if (length == 0)
            {
                // {} -> Dictionary<string, string>
                return typeof(Dictionary<string, string>);
            }

            var valueList = new List<JsonData>(length);

            foreach (var item in data)
            {
                var entry =  (KeyValuePair<string, JsonData>)item;
                valueList.Add(entry.Value);
            }

            Type firstType = GetSimpleJsonDataType(valueList[0]);
            bool isFloat = false;

            for (int i = 1; i < length; ++i)
            {
                Type type = GetSimpleJsonDataType(valueList[i]);
                if (type != firstType)
                {
                    if ((firstType == typeof(int) || firstType == typeof(long)) && type == typeof(float))
                    {
                        isFloat = true;
                        continue;
                    }

                    throw new Exception("!!! error Dictionary type not the same");
                }
            }

            return isFloat ? typeof(Dictionary<string, float>) : GetDictionaryType(firstType);
        }
        else
        {
            return GetSimpleJsonDataType(data);
        }
    }

    private static Type GetDictionaryType(Type type)
    {
        if (type == typeof(bool))
        {
            return typeof(Dictionary<string, bool>);
        }
        else if (type == typeof(int))
        {
            return typeof(Dictionary<string, int>);
        }
        else if (type == typeof(long))
        {
            return typeof(Dictionary<string, long>);
        }
        else if (type == typeof(float))
        {
            return typeof(Dictionary<string, float>);
        }
        else if (type == typeof(string))
        {
            return typeof(Dictionary<string, string>);
        }
        else
        {
            throw new Exception("!!! wtf dictionary value type: " + type);
        }
    }

    private static Type GetSimpleJsonDataType(JsonData data)
    {
        if (data.IsBoolean)
        {
            return typeof(bool);
        }
        else if (data.IsString)
        {
            return typeof(string);
        }
        else if (data.IsDouble)
        {
            return typeof(float);
        }
        else if (data.IsInt)
        {
            return typeof(int);
        }
        else if (data.IsLong)
        {
            return typeof(long);
        }
        else
        {
            throw new Exception("type error: " + data);
        }
    }

    // =============================

    public static string ConfigDir = "Assets/JSONs";

    public static string ProtoClassDir = "Assets/ZeroFormatterGenerated/ConfigClass";
    public static string ProtoBytesDir = "Assets/ZeroFormatterGenerated/ConfigBytes";

    public static string ZeroFormatClassPath = "Assets/ZeroFormatterGenerated/ConfigZeroFormatter.cs";

    public static string ITEM_FORMAT_FILE = @"using ZeroFormatter;
using System.Collections.Generic;

namespace ClientConfig
{{
    [ZeroFormattable]
    public class {0} : ConfigGetItem<{0}>
    {{
        {1}
    }}
}}
";

    public static string ITEM_FORMAT_ROW = @"
    [Index({0})]
    public virtual {1} {2} {{ get; set; }}
";

    private void GenerateClassFile()
    {
        if (Directory.Exists(ProtoClassDir))
        {
            Directory.Delete(ProtoClassDir, true);
        }
        Directory.CreateDirectory(ProtoClassDir);

        foreach (var fileInfo in new DirectoryInfo(ConfigDir).GetFiles("*.json", SearchOption.TopDirectoryOnly))
        {
            try
            {
                if(!fileInfo.Name.StartsWith("EditorOnly-"))
                    GenerateClassInternal(fileInfo);
            }
            catch (Exception e)
            {
                Debug.LogError("!!! error parse: " + fileInfo.Name);
                Debug.LogException(e);
            }
        }
    }

    private void GenerateClassInternal(FileInfo fileInfo)
    {
        /*
         * There are five basic value types supported by JSON Schema:
            string.
            number.
            integer.
            boolean.
            null.

            // 3 types: string int long float
            */
        string jsonStr = File.ReadAllText(fileInfo.FullName);

        JsonData jsons = JsonMapper.ToObject(jsonStr);

        int length = jsons.Count;
        if (length > 0)
        {
            List<ColumDefine> lists = GetJsonDefines(jsons);

            string className = Path.GetFileNameWithoutExtension(fileInfo.Name);
            className = UpperCaseHeader(className);

            string classItemName = className + "Item";
            // generate item
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lists.Count; ++i)
            {
                string content = string.Format(ITEM_FORMAT_ROW, i, TypeToString(lists[i].type), lists[i].name);
                sb.Append(content);
            }

            string itemContent = string.Format(ITEM_FORMAT_FILE, classItemName, sb.ToString());
            string itemPath = Path.Combine(ProtoClassDir, classItemName + ".cs");
            File.WriteAllText(itemPath, itemContent);
        }
    }

    private static string UpperCaseHeader(string className)
    {
        var sb = new StringBuilder();
        sb.Append(className[0].ToString().ToUpper());

        int length = className.Length;
        for (int i = 1; i < length; ++i)
        {
            sb.Append(className[i]);
        }

        return sb.ToString();
    }

    private List<ColumDefine> GetJsonDefines(JsonData jsons)
    {
        var lists = new List<ColumDefine>();

        Dictionary<string, Type> types = GetAllJsonItemTypes(jsons);

        foreach (var item in types)
        {
            ColumDefine define = new ColumDefine()
            {
                name = item.Key,
                type = item.Value,
            };

            lists.Add(define);

        }

        return lists;
    }

    private Dictionary<string, Type> GetAllJsonItemTypes(JsonData jsons)
    {
        Assert.IsTrue(jsons.Count > 0);

        Dictionary<string, Type> dict = new Dictionary<string, Type>();
        
        List<string> keys = GetAllJsonItemKeys(jsons);

        // bool, string, || double(float) int long

        foreach (var key in keys)
        {
            dict.Add(key, GetBestType(jsons, key));
        }

        return dict;
    }

    private Type GetBestType(JsonData jsons, string key)
    {
        JsonData firstJsonData = jsons[0];
        Type firstType = GetJsonDataType(firstJsonData[key]);

        if (jsons.Count > 1)
        {
            if (firstType == typeof(bool) || firstType == typeof(string) || firstType == typeof(float))
            {
                for (int i = 1, length = jsons.Count; i<length; ++i)
                {
                    var jsonData = jsons[i];
                    Type type = GetJsonDataType(jsonData[key]);
                    if (firstType != type)
                    {
                        throw new Exception(string.Format("!!! {0} != {1}", firstType, type));
                    }
                }

                return firstType;
            }
            else if(firstType == typeof(int) || firstType == typeof(long))
            {
                bool isFloat = false;

                for (int i = 1, length = jsons.Count; i < length; ++i)
                {
                    var jsonData = jsons[i];
                    Type type = GetJsonDataType(jsonData[key]);
                    if (type == typeof(float))
                    {
                        isFloat = true;
                        break;
                    }
                }

                return isFloat ? typeof(float) : firstType;
            }
            else if (firstType == typeof(int[]) || firstType == typeof(long[]) || firstType == typeof(string[]) ||
                     firstType == typeof(bool[]) || firstType == typeof(float[]))
            {
                return firstType;
            }
            else if (firstType == typeof(Dictionary<string, int>) || firstType == typeof(Dictionary<string, long>) || firstType == typeof(Dictionary<string, string>) ||
                     firstType == typeof(Dictionary<string, bool>) || firstType == typeof(Dictionary<string, float>))
            {
                return firstType;
            }
            else
            {
                throw new Exception("!!! wtf type: " + firstType);
            }
        }
        else
        {
            return firstType;
        }
    }

    private List<string> GetAllJsonItemKeys(JsonData jsons)
    {
        var keys = new List<string>();

        for (int i = 0, length = jsons.Count; i < length; ++i)
        {
            var json = jsons[i];

            foreach (var key in json.Keys)
            {
                if (!keys.Contains(key))
                {
                    keys.Add(key);
                }
            }
        }

        return keys;
    }

    private void GenerateZeroFomatter()
    {
        string zfcPath = new FileInfo("Assets/3rd_party/ZeroFormatter/zfc.exe").FullName;
        string csprojPath = new FileInfo("Emily.csproj").FullName;
        string outputPath = new FileInfo(ZeroFormatClassPath).FullName;

        string command = string.Format("{0} -i {1} -o {2}", zfcPath, csprojPath, outputPath);
        EditorUtils.ExecuteCommandSync(command);
    }

    private void CallStaticMethod(Type type, string methodName)
    {
        try
        {
            type.GetMethod(methodName, BindingFlags.Public | BindingFlags.Static).Invoke(null, null);
        }
        catch (Exception e)
        {
            Debug.LogException(e);
        }
    }

    private void GenerateBytes()
    {
        if (Directory.Exists(ProtoBytesDir))
        {
            Directory.Delete(ProtoBytesDir, true);
        }
        Directory.CreateDirectory(ProtoBytesDir);

        Type type = Utils.NameToType("ZeroFormatter.ZeroFormatterInitializer");
        if (type != null)
        {
            CallStaticMethod(type, "Register");
        }
        else
        {
            Debug.LogError("can not find type ZeroFormatter.ZeroFormatterInitializer");
        }

        string cdbPath = Application.streamingAssetsPath + "/config.cdb";
        using (CdbWriter cdbWriter = new CdbWriter(cdbPath))
        {
            foreach (var fileInfo in new DirectoryInfo(ConfigDir).GetFiles("*.json", SearchOption.TopDirectoryOnly))
            {
                try
                {
                    if (!fileInfo.Name.StartsWith("EditorOnly-"))
                        GenerateBytesInternal(cdbWriter, fileInfo);
                }
                catch (Exception e)
                {
                    Debug.LogException(e);
                }
            }

            cdbWriter.Finish();
        }
    }

    private static void GenerateBytesInternal(CdbWriter CdbWriter, FileInfo fileInfo)
    {
        string jsonStr = File.ReadAllText(fileInfo.FullName);
        string outputPath = Path.Combine(ProtoBytesDir, Path.GetFileNameWithoutExtension(fileInfo.Name) + ".bytes");

        string className = Path.GetFileNameWithoutExtension(fileInfo.Name);
        className = UpperCaseHeader(className);

        Type classType = Utils.NameToType("ClientConfig." + className + "Item");

        object obj = Activator.CreateInstance(classType);
        var methodInfo = classType.GetMethod("SerializeObject");
        if (methodInfo != null)
            methodInfo.Invoke(obj, new object[] { CdbWriter, jsonStr, outputPath });
    }

    private void CreateAssetBundle()
    {
        List<Object> lists = new List<Object>();

        foreach (var path in Directory.GetFiles(ProtoBytesDir, "*.bytes"))
        {
            var obj = AssetDatabase.LoadAssetAtPath<Object>(path);

            lists.Add(obj);
        }

        EditorUtils.CreateAssetBundle(lists.ToArray(), "config", "client_config.assetbundle");
    }
}
