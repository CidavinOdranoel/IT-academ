using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class Bicycle : Vihecle
    {
        protected override void Fuel()
        {
            throw new NotImplementedException("Bicycle can't be fueled");
        }
    }
}
