using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_HW6
{
    internal class Motorbike : Vehicle
    {
        internal Motorbike(int capacity, string color = "red", int maxSpeed = 200, int baseFuel = 30)
        {
            _transportType = "Motorbike";
            EngineCapacity = capacity;
            Color = color;
            MaxSpeed = maxSpeed;
            Fuel = baseFuel;
        }

        internal int EngineCapacity { get; init; }

        // Move() override is not needed

        internal override bool ToFuel(int fuelAmount)
        {
            if (!base.ToFuel(fuelAmount))
            {               
                return false;
            }
            if (Fuel > EngineCapacity)
            {
                Console.WriteLine("Fuel capacity has been exeeded.");
                Fuel = EngineCapacity;
                return true;
            }
            return true;
        }
    }
}
