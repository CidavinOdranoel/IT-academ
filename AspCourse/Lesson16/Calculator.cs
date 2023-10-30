using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    internal class Calculator : IVersion, IPow
    {
        

        internal double Sum(int x, int y)
        {
            return (double)x + (double)y;
        }

        internal double Substruct(int x, int y)
        {
            return (double)x - (double)y;
        }

        internal double Multiply(int x, int y)
        {
            return (double)x * (double)y;
        }

        internal double Divide(int x, int y)
        {
            return (double)x / (double)y;
        }

        internal void ShowVersion()
        {
            Console.WriteLine(IVersion.version);
        }

        double IPow.Pow(int x, int p)
        {
            return Math.Pow(x, p);
        }
    }
}
