using System.ComponentModel;
using System.Security.Principal;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 8: Prime Numbers
            // Objective: Identify prime numbers within a range using loops.
            // Task: Write a program that reads two integers(start and end) from the user and prints all prime numbers in that range.

            int startOfRange = 0;
            int endOfRange = 0;
            Console.WriteLine("This program prints all prime numbers within the entered range.");
            Console.Write("Please enter start of range: ");
            int.TryParse(Console.ReadLine(), out startOfRange);
            Console.Write("Please enter end of range: ");
            int.TryParse(Console.ReadLine(), out endOfRange);

            bool isPrime = false;

            for (int i = startOfRange; i <= endOfRange; i++)
            {
                isPrime = true;

                for (int j = 1; j <= i; j++)
                {
                    if (j != 1 && j != i && i % j == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime && i != 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
