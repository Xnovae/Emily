using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Entitas;
using UnityEngine;

[Game]
public class TweenResultComponent : IComponent
{
    public Tweener tweener;
    public float value;
}
