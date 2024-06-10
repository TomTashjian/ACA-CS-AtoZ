using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 4: Reverse a String
            // Objective: Use a loop to reverse a string.
            // Task: Write a program that reads a string from the user and prints the reversed string.

            string userInput;
            Console.WriteLine("Please enter a text to display it in reverse order of characters: ");
            userInput = Console.ReadLine();

            for (int i = 0; i < userInput.Length; ++i)
            {
                Console.Write(userInput[(userInput.Length - 1) - i]);
            }
        }
    }
}
