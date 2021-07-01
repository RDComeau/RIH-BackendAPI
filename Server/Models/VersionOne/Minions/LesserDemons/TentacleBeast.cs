using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Server.Models.Enums.Flight;

namespace Server.Models.VersionOne.Minions.LesserDemons
{
    public class TentacleBeast : BaseUnit
    {
        public override int cost { get; set; } = 21;
        public override int move { get; set; } = 8;
        public override int life { get; set; } = 9;
        public override int combat { get; set; } = 4;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.No);
        public override string demonName { get; set; } = "Tentacle Beast";
        public override string className { get; set; } = "Minions: Lesser Demons";
    }
}
