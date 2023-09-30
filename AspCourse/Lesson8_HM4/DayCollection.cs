using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_HM4
{
    internal sealed class DayCollection
    {
        internal enum WeekStyle { American, European }

        internal enum WeekDay 
        { 
            Monday = 1, 
            Tuesday,
            Wednesday,
            Thursday, 
            Friday, 
            Saturday, 
            Sunday
        }

        internal int this[WeekStyle weekStyle, WeekDay weekDay]
        {
            get
            {              
                if (weekStyle == WeekStyle.European)
                {
                    return (int)weekDay;
                }
                else
                {
                    if (weekDay == WeekDay.Sunday)
                    {
                        return 1;
                    }
                    else
                    {
                        return (int)weekDay+1;
                    }
                }
            }
        }
    }
}
