using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18
{
    internal class MyExeption : Exception
    {
        private string _message;

        internal MyExeption()
        {
            _message = "No message";
        }
        internal MyExeption(string message)
        {
            _message = message;
        }
    }
}
