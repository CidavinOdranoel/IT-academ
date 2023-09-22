using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
<<<<<<< Updated upstream
    internal class Bank
    {
=======
    public class Bank
    {
        //string _name;
        //string _version;

        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}
        //public string Version
        //{
        //    get { return _version; }
        //    set { _version = value; }
        //}

        public string Name
        {
            get;
            init;
        }
        public string Version
        {
            get;
            init;
        }

        public Bank(string name = "BankNameDefault")
        {
            Name = name;
            Version = "1.0";
        }
        public Bank(string version = "NotAssigned", string name = "BankNameDefault")
        {
            Name = name;
            Version = version;
        }

        public void PrintBankName()
        {
            Console.WriteLine($"Банк {Name}");
        }
        public void PrintBankVerison()
        {
            Console.WriteLine($"Банк {Version}");
        }
>>>>>>> Stashed changes
    }
}
