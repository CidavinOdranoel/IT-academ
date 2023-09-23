using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_HM3
{
    public static class CharacterCreator
    {
        // Check position
        public static bool IsPositionEmpty(int x, int y)
        {
            Console.WriteLine("Position if empty. Mob created");
            return true;
        }
        // Mage
        public static CharacterMage CreateMage(int x, int y)
        {
            CharacterMage mage = new CharacterMage(x, y);
            return mage;
        }
        // Thief
        public static CharacterThief CreateThief(int x, int y)
        {
            CharacterThief thief = new CharacterThief(x, y);
            return thief;
        }
        // Warrior
        public static CharacterWarrior CreateWarrior(int x, int y)
        {
            CharacterWarrior warrior = new CharacterWarrior(x, y);
            return warrior;
        }
        // Mobs
        public static Mob CreateMob()
        {
            Random rand = new Random();
            Mob mob = new Mob() {CurrentX = rand.Next(0,100), CurrentY = rand.Next(0, 100) };

            //Spawn must be empty
            if (IsPositionEmpty(mob.CurrentX, mob.CurrentY))
            {
                return mob;
            }
            else
            {
                return mob = CreateMob();
            }
        }

    }
}
