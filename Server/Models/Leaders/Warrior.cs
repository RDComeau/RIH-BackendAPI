using Server.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models.Leaders
{
    public class Warrior : BaseUnit
    {
        public override int cost { get; set; } = 0;
        public override int move { get; set; } = 6;
        public override int life { get; set; } = 15;
        public override int combat { get; set; } = 7;
        public override bool fly { get; set; } = Convert.ToBoolean(Fly.No);
    }
}
