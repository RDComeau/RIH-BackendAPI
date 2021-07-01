using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Server.Models.Enums.Flight;

namespace Server.Models.VersionOne.Minions.GreaterDemons
{
    public class SerpentKnight : BaseUnit
    {
        public override int cost { get; set; } = 26;
        public override int move { get; set; } = 7;
        public override int life { get; set; } = 11;
        public override int combat { get; set; } = 7;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.No);
        public override string demonName { get; set; } = "Serpent Knight";
        public override string className { get; set; } = "Minions: Greater Demons";
    }
}
