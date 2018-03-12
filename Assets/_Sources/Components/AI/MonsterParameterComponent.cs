using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

[Game]
public class MonsterParameterComponent : IComponent
{
    public float alarmRange;    // 警戒距离
    public float campusRange;   // 大本营距离，超过就回去
    public float attackRange;   // 攻击距离
    public float attack;        // 攻击力
}
