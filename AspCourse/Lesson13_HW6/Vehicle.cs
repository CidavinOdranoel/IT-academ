using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_HW6
{
    internal abstract class Vehicle
    {
        protected string _transportType;

        protected int MaxSpeed { get; set; }
        protected string Color { get; set; }
        protected int Fuel
        {
            get
            {
                return this.Fuel;
            }
            set
            {
                Fuel = value;
                if (Fuel < 0)
                {
                    Fuel = 0;
                }
            }
        }


        internal virtual void Move()
        {
            Console.WriteLine($"{_transportType} is moving...");
        }

        /// <summary>
        /// Fuel a vehicle. Returns true if fueled for more, than 0. False otherwise.
        /// </summary>
        /// <param name="fuelAmount">Fuel amount</param>
        internal virtual bool ToFuel(int fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                Console.WriteLine($"{_transportType} is not fueled");
                return false;
            }
            Fuel = Fuel + fuelAmount;
            Console.WriteLine($"{_transportType} is fueled for {fuelAmount}. Curret fuel: {Fuel}");
            return true;
        }
    }
}
