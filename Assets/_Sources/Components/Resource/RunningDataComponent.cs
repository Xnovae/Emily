using System.Collections;
using System.Collections.Generic;
using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Game, Unique]
public class RunningDataComponent : IComponent
{
    public ResourceData ResourceData;
    public RuntimeData RuntimeData;
}
