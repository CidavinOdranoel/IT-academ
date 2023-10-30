using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_HW6
{
    internal class Bicycle : Vehicle
    {
        internal Bicycle(string bicycleType, string color = "blue", int maxSpeed = 50, int baseFuel = 30)
        {
            _transportType = "Bicycle";
            BicycleType = bicycleType;
            Color = color;
            MaxSpeed = maxSpeed;
            Fuel = baseFuel;
        }

        string BicycleType { get; set; }

        internal new void Move()
        {
            Console.WriteLine($"Someone is riding a bicycle. It's {BicycleType}");
        }

        internal override bool ToFuel(int fuelAmount)
        {
            Console.WriteLine("Bicycle can not be fueled");
            return false;
        }
    }
}
