using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_HM3
{
    public sealed class CharacterWarrior : CharacterBase
    {
        public CharacterWarrior(int x, int y)
        {
            Type = "Warrior";
            Status = "Default";
            HealthPoints = 200;
            Damgae = 7;
            Defense = 6;
            CurrentX = x;
            CurrentY = y;
        }
        protected override void Attack()
        {
            Console.WriteLine($"{Type} slashes for {Damgae} damage");
        }

        protected override void Defend()
        {
            Console.WriteLine($"Warrior is blocking {Defense} damage");
        }
    }
}
