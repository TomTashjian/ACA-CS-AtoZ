using System.Text.Json;
using System.Text;
using System;

namespace _003_FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Person> PersonList = new List<Person>()
                {
                    new Person() { FirstName = "John", LastName = "Doe", BirthDate = DateOnly.Parse("1/1/1980")},
                    new Person() { FirstName = "Tom", LastName = "Smith", BirthDate = DateOnly.Parse("2/2/1990")},
                    new Person() { FirstName = "Ben", LastName = "Big", BirthDate = DateOnly.Parse("3/3/2000")}
                };
                List<Person> ReadPersonList = new List<Person>();

                FileStream fileStream = File.Open("Person.json", FileMode.Create, FileAccess.ReadWrite);

                // Serialize/Deserialize List<Person> instead of individual Person objects
                JsonSerializer.Serialize(fileStream, PersonList);
                fileStream.Position = 0;
                ReadPersonList = JsonSerializer.Deserialize<List<Person>>(fileStream) ?? new List<Person>();
                fileStream.Close();

                Console.WriteLine("Reading file as text..");
                Console.WriteLine("--Start of File--");
                Console.WriteLine(File.ReadAllText("Person.json"));
                Console.WriteLine("--End of File--\n");

                Console.WriteLine("Printing Person list read from file (each line correspond to properties of a Person)..");
                foreach (var person in ReadPersonList)
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName} {person.BirthDate}");
                }
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
