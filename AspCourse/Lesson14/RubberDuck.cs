using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    internal class RubberDuck : DuckBase
    {
        internal override void Swim()
        {
            Console.WriteLine("Duck is floating");
        }

        internal override void Fly()
        {
            Console.WriteLine("Rubber ducks dont fly");
        }
    }
}
