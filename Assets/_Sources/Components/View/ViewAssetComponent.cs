using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

[Game]
public class ViewAssetComponent : IComponent
{
    public tk2dSpriteCollectionData collectionData;
    public string spriteName;
}
