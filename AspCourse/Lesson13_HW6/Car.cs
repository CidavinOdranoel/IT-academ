using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_HW6
{
    internal class Car : Vehicle
    {
        internal Car(string color = "white", int baseFuel = 30, string brand = "Not specified")
        {
            _transportType = "Car";
            MaxSpeed = 180;
            Color = color;
            Fuel = baseFuel;
            Brand = brand;
        }

        string Brand { get; set; }

        /// <summary>
        /// If Brand of a car is specified write as "{Brand} is moving"
        /// </summary>
        internal override void Move()
        {
            if (IsCarSpecified(this))
            {
                Console.WriteLine($"{Brand} is moving...");
            }
            else
            {
                base.Move();
            }
        }

        /// <summary>
        /// Defines if a car brand is specified
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        internal bool IsCarSpecified(Car car)
        {
            if (Brand == "Not specified" || String.IsNullOrEmpty(Brand))
            {
                return false;
            }
            return true;
        }

        internal override bool ToFuel(int fuelAmount)
        {
            if (!IsCarSpecified(this))
            {
                base.ToFuel(fuelAmount);
            }

            if (fuelAmount <= 0)
            {
                Console.WriteLine($"{Brand} is not fueled");
                return false;
            }
            Fuel = Fuel + fuelAmount;
            Console.WriteLine($"{Brand} is fueled for {fuelAmount}. Curret fuel: {Fuel}");
            return true;
        }
    }
}
