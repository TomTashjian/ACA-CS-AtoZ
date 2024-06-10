using System.ComponentModel;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 3: Multiplication Table
            // Objective: Generate a multiplication table using nested loops.
            // Task: Write a program that prints the multiplication table for numbers 1 to 10.

            for(int i = 1; i <= 10; ++i)
            {
                for (int j = 1; j <= 10; ++j)
                {
                    Console.WriteLine($"{i} x {j} = " + (i * j));
                }
            }
        }
    }
}
