
using System.Globalization;

namespace _001_FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> PersonList = new List<Person>()
            {
                new Person() { FirstName = "John", LastName = "Doe", BirthDate = DateOnly.Parse("1/1/1980")},
                new Person() { FirstName = "Tom", LastName = "Smith", BirthDate = DateOnly.Parse("2/2/1990")},
                new Person() { FirstName = "Bill", LastName = "Jones", BirthDate = DateOnly.Parse("3/3/2000")}
            };

            List<string> PersonStrings = new List<string>();
            foreach (Person person in PersonList)
            {
                PersonStrings.Add(PersonFileUtility.ConvertPersonIntoCSVString(person, PersonList.IndexOf(person) == 0));
            }

            Console.WriteLine("writing to CSV file..");
            File.WriteAllLines("Persons.csv", PersonStrings);
            Console.WriteLine("done");

            Console.WriteLine("reading from CSV file..");
            Console.WriteLine("\n--Start of File--");
            string[] FileLines= File.ReadAllLines("Persons.csv");
            for(int i = 0; i < FileLines.Length; ++i)
            {
                Console.WriteLine(FileLines[i]);
            }
            Console.WriteLine("--End of File--\n");

            List<Person> ReadPersonList = new List<Person>();
            foreach (string line in FileLines)
            {
                if (Array.IndexOf(FileLines, line) == 0)
                {
                }
                else
                {
                    ReadPersonList.Add(PersonFileUtility.ParseCSVStringIntoPerson(line));
                }
            }

            Console.WriteLine("Persons read from file:");
            foreach (Person person in ReadPersonList)
            {
                Console.WriteLine($"\"{person.FirstName}\" \"{person.LastName}\" \"{person.BirthDate}\"");
            }


        }
    }
}
