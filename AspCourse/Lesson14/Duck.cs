using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    internal class Duck : DuckBase
    {
        internal override void Swim()
        {
            Console.WriteLine("Duck is swimming");
        }
    }
}
