using System.Runtime.InteropServices;

namespace Task1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1.3: Calculate Age
            // Objective: Create a console application that asks the user for their year of birth and calculates their age.

            Console.Write("Enter your year of birth: ");
            string? yearOfBirth = Console.ReadLine();
            if (string.IsNullOrEmpty(yearOfBirth) || string.IsNullOrWhiteSpace(yearOfBirth))
                Console.WriteLine("you did not enter year of birth");
            else
            {
                try 
                { 
                    Console.WriteLine("You are {0} years old!", DateTime.Now.Year - int.Parse(yearOfBirth)); 
                }
                catch (Exception) 
                { 
                    Console.WriteLine("Invalid year of birth!");
                }
            }
        }
    }
}
