using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_HW7
{
    internal abstract class Vehicle 
    {
        
        internal uint Fuel {  get; set; }
        internal string Brand { get; set; }
        internal uint EngineCapacity { get; set; }

        internal Vehicle(uint fuel, string brand, uint engineCapacity)
        {
            Fuel = fuel;
            Brand = brand;
            EngineCapacity = engineCapacity;
        }

        internal void StartMoving()
        {
            Console.WriteLine("Vehicle starts moving...");
        }

        internal abstract void StopMoving();

        static public object Clone() 
        {
            return new Vehicle();
        }
    }
}
