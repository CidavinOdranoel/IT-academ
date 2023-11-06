using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    internal class DroneDuck : DuckBase
    {
        internal override void Swim()
        {
            Console.WriteLine("Drones can't swim");
        }

        internal override void Fly()
        {
            base.Fly();
            Console.WriteLine("Drone is watching you");
        }
    }
}
