using System;

namespace Task1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1.1: User Information (Separate Lines)
            // Objective: Create a console application that asks the user for their name, surname, age, and profession and prints them in the console in separate lines.

            Console.Write("Please enter your name: ");
            string? name = Console.ReadLine();
            Console.Write("Please enter your surname: ");
            string? surname = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string? age = Console.ReadLine();
            Console.Write("Please enter your profession: ");
            string? professoin = Console.ReadLine();
            Console.WriteLine("your name: {0}\nyour surname: {1}\nyour age: {2}\nyour profession: {3}", name, surname, age, professoin);
        }
    }
}
