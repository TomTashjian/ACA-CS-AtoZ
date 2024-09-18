using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_FileIO
{
    internal static class PersonFileUtility
    {
        public static string GetPersonString(Person person, bool addLabel = false)
        {
            string result = "";
            if (addLabel)
            {
                result += "First Name, Last Name, Birth Date\n";
            }
            result += $"{person.FirstName}, {person.LastName}, {person.BirthDate}";
            return result;
        }
    }
}
