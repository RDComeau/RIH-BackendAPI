using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Server.Models.Enums.Flight;

namespace Server.Models.VersionOne.Devouts
{
    public class Executioner : BaseUnit
    {
        public override int cost { get; set; } = 0;
        public override int move { get; set; } = 5;
        public override int life { get; set; } = 12;
        public override int combat { get; set; } = 8;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.No);
        public override string demonName { get; set; } = "Executioner";
        public override string className { get; set; } = "Devouts";
    }
}
