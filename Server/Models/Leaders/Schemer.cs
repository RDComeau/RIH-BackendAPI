using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models.Leaders
{
    public class Schemer : BaseUnit
    {
        public override int cost { get; set; } = 0;
        public override int move { get; set; } = 8;
        public override int life { get; set; } = 11;
        public override int combat { get; set; } = 5;
    }
}
