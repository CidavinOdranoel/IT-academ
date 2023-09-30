using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_HM4
{
    internal class Rating
    {
        public int Rate { get; set; }

        Random rdm = new Random();
        internal enum ClassLetter
        {
            A, B, C, D, E, F, G, H
        }
        internal int this[ClassLetter classLetter, string name]
        {
            get
            {
                if (!IsPupilExist(classLetter, name)) throw new NotImplementedException("Pupil doesn't exist");
                return rdm.Next(1,101);
            }
            set
            {
                Rate = value;
            }
        }

        private bool IsPupilExist(ClassLetter classLetter, string pupilName)
        {
            return true;
        }
    }
}
