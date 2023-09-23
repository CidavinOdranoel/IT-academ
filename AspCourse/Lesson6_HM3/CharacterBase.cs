using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_HM3
{
    public abstract class CharacterBase
    {
        public string Type { get; init; }
        public string Status { get; set; }
        public int CurrentX { get; set; }
        public int CurrentY { get; set; }
        public int HealthPoints { get; set; }
        public int Damgae { get; set; }
        public int Defense { get; set; }


        protected abstract void Attack();
        protected abstract void Defend();
        protected void Move(string direction) 
        {
            switch (direction)
            {
                case "left":
                    Console.WriteLine($"{Type} is moving {direction}");
                    CurrentX++;
                     break;
                case "right":
                    Console.WriteLine($"{Type} is moving {direction}");
                    CurrentX--;
                     break;
                case "up":
                    Console.WriteLine($"{Type} is moving {direction}");
                    CurrentY++;
                     break;
                case "down":
                    Console.WriteLine($"{Type} is moving {direction}");
                    CurrentY--;
                     break;
                default: throw new NotImplementedException("Invalid movement direction");
            }
        }

    }
}
