using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class TearDownConfigManagerSystem : ITearDownSystem
{
    public void TearDown()
    {
        ConfigManager.Instance.Close();
    }
}
