using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_HW8
{
    internal class EmptyStringException : Exception
    {
        public EmptyStringException()
        {
            Console.WriteLine("Strting is empty.");
        }
        public EmptyStringException(string message)
            : base(message)
        {

        }
        public EmptyStringException(string message, Exception inner)
            : base(message, inner)
        {

        }


    }
}
