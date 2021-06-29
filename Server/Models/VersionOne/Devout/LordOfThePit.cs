using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Server.Models.Enums.Flight;

namespace Server.Models.VersionOne.Devout
{
    public class LordOfThePit : BaseUnit
    {
        public override int cost { get; set; } = 0;
        public override int move { get; set; } = 8;
        public override int life { get; set; } = 12;
        public override int combat { get; set; } = 7;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.Yes);
    }
}
