using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Entitas;
using UnityEngine;

public class InitSystem : IInitializeSystem
{
    public InitSystem(Contexts contexts)
    {
    }

    public void Initialize()
    {
        DOTween.Init(true, false, LogBehaviour.Default).SetCapacity(200, 10);    // recycleAllByDefault, useSafeMode
    }
}
