using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_HM4
{
    internal class Thermo
    {
        Random rdm = new Random();
        internal enum Month
        {
            January = 31,
            February = 28,
            March = 31,
            April = 30,
            May = 31,
            June = 30,
            Jule = 31,
            August = 31,
            September = 30,
            October = 31,
            November = 30,
            December = 31
        }

        public int this[Month month, int day]
        {
            get
            {
                if (day > (int)month || day <= 0) throw new ArgumentOutOfRangeException();
                return rdm.Next(-30, 30);
            }
            set { throw new ArgumentOutOfRangeException(); }

        }
    }
}
