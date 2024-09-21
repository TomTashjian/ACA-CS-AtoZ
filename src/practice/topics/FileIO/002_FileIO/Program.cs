using System;
using System.Text;
using System.Text.Json;

namespace _002_FileIO
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
                    new Person() { FirstName = "Ben", LastName = "Big", BirthDate = DateOnly.Parse("3/3/2000")},
                    new Person() { FirstName = "Bill", LastName = "Johnson", BirthDate = DateOnly.Parse("4/4/2001")},
                };

                List<Person> ReadPersonList= new List<Person>();

                FileStream fileStream = File.Open("Person.json", FileMode.Create, FileAccess.ReadWrite);

                // Serialize/Deserialize individual Person objects
                fileStream.WriteByte((byte)'[');
                foreach (var person in PersonList)
                {
                    JsonSerializer.Serialize(fileStream, person);
                    if (PersonList.IndexOf(person) != PersonList.Count - 1)
                    {
                        fileStream.WriteByte((byte)',');
                    }
                }
                fileStream.WriteByte((byte)']');

                // not working because JsonSerializer.Deserialize<Person>(fileStream) reads the entire file
                //fileStream.Position = 0;
                //while (fileStream.Position < fileStream.Length)
                //{
                //    ReadPersonList.Add(JsonSerializer.Deserialize<Person>(fileStream));
                //}

                // read the file as text and store it as individual json strings
                fileStream.Position = 0;
                byte[] buffer = new byte[fileStream.Length];
                int byteRead = fileStream.Read(buffer);
                string fileText = Encoding.UTF8.GetString(buffer);
                fileText = fileText.Remove(0, 1); // remove the first '['
                fileText = fileText.Remove(fileText.Length - 1, 1); // remove the last ']'
                string[] jsonStrings = fileText.Split("},");
                fileText = string.Join("}", jsonStrings);
                jsonStrings = fileText.Split("}");
                // Deserialize each json string and add it to ReadPersonList
                foreach (string jsonString in jsonStrings)
                {
                    if (!string.IsNullOrEmpty(jsonString))
                    {
                        ReadPersonList.Add(JsonSerializer.Deserialize<Person>(jsonString + '}') ?? new Person());
                    }
                }

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
            catch(System.IO.IOException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
