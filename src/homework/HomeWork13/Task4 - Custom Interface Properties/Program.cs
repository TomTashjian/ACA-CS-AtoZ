// Custom Interface Properties:
// Design an interface IStudent with properties Name, Age, and Grade.
// Create a class Student that implements this interface. Students should set values for these properties and retrieve them.

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStudent student = new Student();
            student.Name = "John Doe";
            student.Age = 20;
            student.Grade = "A";

            System.Console.WriteLine($"Name: {student.Name}");
            System.Console.WriteLine($"Age: {student.Age}");
            System.Console.WriteLine($"Grade: {student.Grade}");
        }
    }
}
