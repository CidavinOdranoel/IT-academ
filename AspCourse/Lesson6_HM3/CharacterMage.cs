using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_HM3
{
    public partial class CharacterMage : CharacterBase
    {
        public CharacterMage(int x, int y)
        {
            Type = "Mage";
            Status = "Default";
            HealthPoints = 70;
            Damgae = 15;
            Defense = 0;
            CurrentX = x;
            CurrentY = y;
        }

        protected override void Attack()
        {
            Console.WriteLine($"Mage deals {Damgae} magic damage");
        }

        protected override void Defend()
        {
            Console.WriteLine("Mage has no defense");
        }
    }
}
