using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Server.Models.Enums.Flight;

namespace Server.Models.VersionOne.Minions.LesserDemons
{
    public class SpinedDemon : BaseUnit
    {
        public override int cost { get; set; } = 19;
        public override int move { get; set; } = 6;
        public override int life { get; set; } = 7;
        public override int combat { get; set; } = 6;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.No);
        public override string demonName { get; set; } = "Spined Demon";
        public override string className { get; set; } = "Minions: Lesser Demons";
    }
}
