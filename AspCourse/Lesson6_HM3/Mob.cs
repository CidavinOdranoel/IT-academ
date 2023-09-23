using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_HM3
{
    public record class Mob
    {
        public int CurrentX { get; set; }
        public int CurrentY { get; set; }
        public int Health { get; set; }

        public void Death()
        {
            Console.WriteLine("Mob was killed");
            Health = 0;
        }

    }
}
