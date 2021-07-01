using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Server.Models.Enums.Flight;

namespace Server.Models.VersionOne.Minions.LesserDemons
{
    public class ArmoredDemon : BaseUnit
    {
        public override int cost { get; set; } = 22;
        public override int move { get; set; } = 4;
        public override int life { get; set; } = 13;
        public override int combat { get; set; } = 5;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.No);
        public override string demonName { get; set; } = "Armored Demon";
        public override string className { get; set; } = "Minions: Lesser Demons";
    }
}
