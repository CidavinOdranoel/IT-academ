using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class CarPatrol : Vihecle
    {
        protected override void Fuel()
        {
            Console.WriteLine("Fueled with patrol");
        }
    }
}
