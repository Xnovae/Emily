using ZeroFormatter;
using System.Collections.Generic;

namespace ClientConfig
{
    [ZeroFormattable]
    public class MapItem : ConfigGetItem<MapItem>
    {
        
    [Index(0)]
    public virtual int id { get; set; }

    [Index(1)]
    public virtual string name { get; set; }

    [Index(2)]
    public virtual int width { get; set; }

    [Index(3)]
    public virtual int height { get; set; }

    [Index(4)]
    public virtual string pathFormat { get; set; }

    }
}
