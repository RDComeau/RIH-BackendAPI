using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Server.Models.Enums.Flight;

namespace Server.Models.VersionOne.Minions.GreaterDemons
{
    public class MarquessDWinter : BaseUnit
    {
        public override int cost { get; set; } = 24;
        public override int move { get; set; } = 4;
        public override int life { get; set; } = 11;
        public override int combat { get; set; } = 6;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.No);
        public override string demonName { get; set; } = "Marquess d'Winter";
        public override string className { get; set; } = "Minions: Greater Demons";
    }
}
