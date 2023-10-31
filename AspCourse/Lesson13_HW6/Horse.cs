using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_HW6
{
    internal class Horse :Vehicle
    {
        internal Horse(string name, string breed, string color = "brown", int maxSpeed = 80, int baseEnergy = 30) 
        {
            _transportType = "Horse";
            Name = name;
            Breed = breed;
            Color = color;
            MaxSpeed = maxSpeed;
            Fuel = baseEnergy;
        }

        internal string Name { get; set; }
        internal string Breed { get; set; }

        private const int MaxEnergy = 100;

        internal override void Move()
        {
            Console.WriteLine("Horse is running...");
        }

        /// <summary>
        /// Refill the energy of thhe horse
        /// </summary>
        internal new void ToFuel()
        {
            Console.WriteLine("Horse is resting and regaining energy...");
            Fuel = MaxEnergy;
        }
    }
}
