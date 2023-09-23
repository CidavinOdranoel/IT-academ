using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
<<<<<<< Updated upstream
    internal class NationalBank
    {
=======
    public static class NationalBank
    {
        public static Bank CreateBank (string name)
        {
            return new Bank (name);
        }
        public static Bank CreateBank(string version, string name)
        {
            return new Bank(version, name);
        }
>>>>>>> Stashed changes
    }
}
