using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_HW7
{
    internal class Car : Vehicle
    {
        public Car(uint fuel, string brand, uint engineCapacity) :
            base(fuel, brand, engineCapacity)
        { }

        internal override void StopMoving()
        {
            throw new NotImplementedException();
        }

        static internal object Clone()
        {
            return new Car(Fuel, Brand, EngineCapacity);
        }
    }
}
