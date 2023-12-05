using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_HM3
{
    public abstract class CharacterBase
    {
        // Character Type
        public string Type { get; init; }
        public string Status { get; set; }

        // Stats
        public int HealthPoints { get; set; }
        public int Damgae { get; set; }
        public int Defense { get; set; }

        // Position
        public int CurrentX { get; set; }
        public int CurrentY { get; set; }

        // Actions
        protected abstract void Attack();
        protected abstract void Defend();

        // Show info
        public void ShowCharacterType()
        {
            Console.WriteLine(Type);
        }
        public void ShowCharacterStats()
        {
            Console.WriteLine($"Health - {HealthPoints}, Damage - {Damgae}, Defense {Defense}");
        }
        public void ShowPosition()
        {
            Console.WriteLine($"X - {CurrentX}, Y - {CurrentY}");
        }

        // Movement
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
