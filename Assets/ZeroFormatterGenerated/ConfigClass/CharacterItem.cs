using ZeroFormatter;
using System.Collections.Generic;

namespace ClientConfig
{
    [ZeroFormattable]
    public class CharacterItem : ConfigGetItem<CharacterItem>
    {
        
    [Index(0)]
    public virtual string id { get; set; }

    [Index(1)]
    public virtual string name { get; set; }

    [Index(2)]
    public virtual string path { get; set; }

    [Index(3)]
    public virtual string[] actionIdle { get; set; }

    [Index(4)]
    public virtual string[] actionRun { get; set; }

    [Index(5)]
    public virtual string[] actionLightAttack1 { get; set; }

    [Index(6)]
    public virtual string[] actionLightAttack2 { get; set; }

    [Index(7)]
    public virtual string[] actionHeavyAttack1 { get; set; }

    [Index(8)]
    public virtual string[] actionHeavyAttack2 { get; set; }

    [Index(9)]
    public virtual string[] actionLevelUp { get; set; }

    [Index(10)]
    public virtual string[] actionDie { get; set; }

    [Index(11)]
    public virtual int renderOffsetX { get; set; }

    [Index(12)]
    public virtual float renderOffsetY { get; set; }

    }
}
