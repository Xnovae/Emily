using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

[Game]
public class ViewComponent : IComponent
{
    public IViewController viewController;

    public string name;                     // GameObject name

    public bool simpleView;                 // is just for show
}
