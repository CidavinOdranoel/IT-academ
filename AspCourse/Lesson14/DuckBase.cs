using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    internal abstract class DuckBase
    {
        internal abstract void Swim();

        internal virtual void Fly() 
        {
            Console.WriteLine("Duck is flying");
        }
        internal virtual void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
