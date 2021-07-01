using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Server.Models.Enums.Flight;

namespace Server.Models.VersionOne.Devouts
{
    public class Succubus : BaseUnit
    {
        public override int cost { get; set; } = 0;
        public override int move { get; set; } = 6;
        public override int life { get; set; } = 9;
        public override int combat { get; set; } = 4;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.Yes);
        public override string demonName { get; set; } = "Succubus";
        public override string className { get; set; } = "Devouts";
    }
}
