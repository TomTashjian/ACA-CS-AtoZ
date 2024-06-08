using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 2: Count Occurrences of a Character
            // Objective: Use a loop to count occurrences of a specific character in a string.
            // Task: Write a program that reads a string and a character from the user and counts how many times the character appears in the string.

            string inputString;
            char inputChar;
            int numberOfOccurences = 0;

            Console.WriteLine("Please enter a string: ");
            inputString = Console.ReadLine();
            Console.WriteLine("Please enter a character: ");
            inputChar = Console.ReadKey().KeyChar;
            Console.ReadLine();

            for (int i =0; i < inputString.Length; ++i)
            {
                if (inputString[i] == inputChar)
                {
                    numberOfOccurences++;
                }
            }

            Console.WriteLine($"Number of occurrences of the character '{inputChar}':");
            Console.WriteLine(numberOfOccurences);

        }
    }
}
