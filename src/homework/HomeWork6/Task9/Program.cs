using System.ComponentModel;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 9: Pattern Printing
            // Objective: Print patterns using nested loops.
            // Task: Write a program that prints a pyramid pattern of stars with N levels.

            Console.WriteLine("Please enter a number: ");
            int pyramidLevels = 0;
            int.TryParse(Console.ReadLine(), out pyramidLevels);

            for (int i = 1; i <= pyramidLevels; i++)
            {
                for (int j = 1; j <= pyramidLevels - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= ((i * 2) - 1); j++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }
        }
    }
}
