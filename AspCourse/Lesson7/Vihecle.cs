using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal abstract class Vihecle
    {
        string _name;

        public string Name { get { return _name; } set { _name = value; } }

        protected void Start()
        {
            Console.WriteLine("Vehicle ON");
        }
        protected void Stop()
        {
            Console.WriteLine("Vehicle OFF");
        }
        protected abstract void Fuel();

    }
}
