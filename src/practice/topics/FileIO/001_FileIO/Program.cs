using System.Transactions;

namespace _001_FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> PersonList = new List<Person>()
            {
                new Person() { FirstName = "John", LastName = "Doe", BirthDate = DateOnly.Parse("1/1/1980")},
                new Person() { FirstName = "Tom", LastName = "Smith", BirthDate = DateOnly.Parse("2/2/1990")}
            };

            List<string> PersonStrings = new List<string>();
            foreach (Person person in PersonList)
            {
                PersonStrings.Add(PersonFileUtility.GetPersonString(person, PersonList.IndexOf(person) == 0));
            }

            Console.WriteLine("writing to CSV file..");
            File.WriteAllLines("Persons.csv", PersonStrings);
            Console.WriteLine("done");

            Console.WriteLine("reading from CSV file..");
            string[] FileLines= File.ReadAllLines("Persons.csv");
            for(int i = 0; i < FileLines.Length; ++i)
            {
                Console.WriteLine(FileLines[i]);
            }
        }
    }
}
