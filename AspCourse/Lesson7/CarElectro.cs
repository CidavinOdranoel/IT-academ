using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class CarElectro : Vihecle
    {
        protected override void Fuel()
        {
            Console.WriteLine("Vihecle was charged");
        }
    }
}
