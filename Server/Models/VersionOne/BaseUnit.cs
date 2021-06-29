using Server.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models.VersionOne
{
    public abstract class BaseUnit
    {
        abstract public int cost { get; set; }
        abstract public int move { get; set; }
        abstract public int life { get; set; }
        abstract public int combat { get; set; }
        abstract public bool fly { get; set; }
    }
}
