using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class UWADebugSystem : IInitializeSystem, ITearDownSystem
{
    public UWADebugSystem(Contexts contexts)
    { }

    public void Initialize()
    {
#if !UNITY_EDITOR && UNITY_ANDROID && DEVELOPMENT_BUILD
        UWAEngine.StaticInit();

        UWAEngine.Start(UWAEngine.Mode.Overview);
#endif
    }

    public void TearDown()
    {
#if !UNITY_EDITOR && UNITY_ANDROID && DEVELOPMENT_BUILD
        UWAEngine.Stop();
#endif
    }
}
