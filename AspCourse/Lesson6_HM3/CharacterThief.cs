using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_HM3
{
    public class CharacterThief : CharacterBase
    {
        public CharacterThief(int x, int y)
        {
            Type = "Thief";
            Status = "Default";
            HealthPoints = 120;
            Damgae = 10;
            Defense = 2;
            CurrentX = x;
            CurrentY = y;
        }
        protected override void Attack()
        {
            Console.WriteLine($"{Type} stabs for {Damgae} damage");
        }

        protected override void Defend()
        {
            Console.WriteLine($"Thief is blocking {Defense} damage");
        }
    }
}
