using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 5: Print Even Numbers
            // Objective: Use a loop to print even numbers within a specified range.
            // Task: Write a program that reads two integers(start and end) from the user and prints all even numbers in that range.
            
            int startOfRange = 0;
            int endOfRange = 0;

            Console.WriteLine("Please specify a range of numbers:");
            Console.WriteLine("Start of range:");
            int.TryParse(Console.ReadLine(), out startOfRange);
            Console.WriteLine("End of range:");
            int.TryParse(Console.ReadLine(), out endOfRange);

            Console.WriteLine("printing even number of that range:");
            for (int i = startOfRange; i <= endOfRange; ++i)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
