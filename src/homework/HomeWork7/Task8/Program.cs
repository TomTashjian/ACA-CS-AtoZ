using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 8: Generate Random Numbers
            // Objective: Use a loop to generate and print random numbers.
            // Task: Write a program that generates 10 random numbers between 1 and 100 and prints them.

            int count = 10;
            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(rnd.Next(1, 100));
            }
        }
    }
}
