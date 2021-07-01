using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Server.Models.Enums.Flight;

namespace Server.Models.VersionOne.Leaders
{
    public class NewLeader : BaseUnit
    {
        public override int cost { get; set; } = 0;
        public override int move { get; set; } = 0;
        public override int life { get; set; } = 0;
        public override int combat { get; set; } = 0;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.No);
        public override string demonName { get; set; }
        public override string className { get; set; } = "Leaders";
    }
}
