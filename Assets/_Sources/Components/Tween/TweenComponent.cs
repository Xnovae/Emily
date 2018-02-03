using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

[Game]
public class TweenComponent : IComponent
{
    public float startValue;
    public float endValue;
    public float duration;
    public bool repeat;
}
