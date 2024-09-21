using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_FileIO
{
    internal static class PersonFileUtility
    {
        public static string ConvertPersonIntoCSVString(Person person, bool addLabel = false)
        {
            string result = "";
            if (addLabel)
            {
                result += "First Name, Last Name, Birth Date\n";
            }
            result += $"{person.FirstName}, {person.LastName}, {person.BirthDate}";
            return result;
        }

        public static Person ParseCSVStringIntoPerson(string personString)
        {
            string[] strings = personString.Split(',');

            Person person = new Person()
            {
                FirstName = strings[0].Trim(),
                LastName = strings[1].Trim(),
                BirthDate = DateOnly.Parse(strings[2].Trim())
            };
            return person;
        }
    }
}
