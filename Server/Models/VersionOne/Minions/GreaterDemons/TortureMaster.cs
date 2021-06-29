using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Server.Models.Enums.Flight;

namespace Server.Models.VersionOne.Minions.GreaterDemons
{
    public class TortureMaster : BaseUnit
    {
        public override int cost { get; set; } = 27;
        public override int move { get; set; } = 6;
        public override int life { get; set; } = 10;
        public override int combat { get; set; } = 6;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.No);
    }
}
