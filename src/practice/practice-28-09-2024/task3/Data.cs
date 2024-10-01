using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public static class MyData
    {
        public static List<Pet> pets = new List<Pet>() 
        { 
            new Pet() { Id = 0, Name = "Max"},
            new Pet() { Id = 1, Name = "Hancho"},
            new Pet() { Id = 2, Name = "Caesar"},
        };

        public static List<Person> persons = new List<Person>()
        {
            new Person() { age = 20, name = "Felix"},
            new Person() { age = 21, name = "Harry"},
            new Person() { age = 22, name = "Caesar"},
        };
    }
}
