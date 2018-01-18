using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroFormatterBuildStage
{
    public static readonly string ZERO_FORMATTER_BUILD_STAGE_IDENTIFIER = "ZERO_FORMATTER_BUILD_STAGE_IDENTIFIER";
    public static readonly string ZERO_FORMATTER_BUILD_STAGE_RUNNING = "ZERO_FORMATTER_BUILD_STAGE_RUNNING";

    public enum Stage
    {
        None,           // dummy stage
        TriggerBuild,   // 触发编译

        GenerateClassFiles,
        GenerateZeroFormatter,
        GenerateBytes,
        CreateAssetBundle,
    }
}
