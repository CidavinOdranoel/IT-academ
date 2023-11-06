using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_HW8
{
    internal class PersonInfo
    {
        internal string Name { get; private set; }
        internal string Surname { get; private set; }
        internal string Adress { get; private set; }

        // Throw EmptyStringException if one of the fields is empty string
        internal PersonInfo(string name, string surname, string adress)
        {
            if (name == String.Empty)
            {
                throw new EmptyStringException("Constructor: Name field is empty");
            }
            if (surname == String.Empty)
            {
                throw new EmptyStringException("Constructor: Surname field is empty");
            }
            if (adress == String.Empty)
            {
                throw new EmptyStringException("Constructor: Adress field is empty");
            }

            Name = name;
            Surname = surname;
            Adress = adress;
        }

        // Changing fields
        internal void ChangeName(string newName)
        {
            if (newName == String.Empty)
            {
                throw new EmptyStringException("New name field is empty");
            }

            Name = newName;
        }
        internal void ChangeSurname(string newSurname)
        {
            if (newSurname == String.Empty)
            {
                throw new EmptyStringException("New surname field is empty");
            }

            Surname = newSurname;
        }
        internal void ChangeAdress(string newAdress)
        {
            if (newAdress == String.Empty)
            {
                throw new EmptyStringException("New adress field is empty");
            }
            Adress = newAdress;
        }
    }
}
