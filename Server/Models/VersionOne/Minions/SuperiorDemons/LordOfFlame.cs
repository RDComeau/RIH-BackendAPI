using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Server.Models.Enums.Flight;

namespace Server.Models.VersionOne.Minions.SuperiorDemons
{
    public class LordOfFlame : BaseUnit
    {
        public override int cost { get; set; } = 36;
        public override int move { get; set; } = 8;
        public override int life { get; set; } = 11;
        public override int combat { get; set; } = 7;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.Yes);
        public override string demonName { get; set; } = "Lord Of Flame";
        public override string className { get; set; } = "Minions: Superior Demons";
    }
}
