using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 5: Count Vowels in a String
            // Objective: Use a loop to count the number of vowels in a string.
            // Task: Write a program that reads a string from the user and counts the number of vowels(a, e, i, o, u) in the string.

            string userInput;
            Console.WriteLine("Please enter a string to calculate the number of vowels in it: ");
            userInput = Console.ReadLine();

            int numberOfVowels = 0;

            for (int i = 0; i < userInput.Length; ++i)
            {
                if (userInput[i] == 'a' || userInput[i] == 'e' || userInput[i] == 'i' || userInput[i] == 'o' || userInput[i] == 'u')
                {
                    ++numberOfVowels;
                }
            }

            Console.WriteLine("number of vowels in the entered string = " + numberOfVowels);
        }
    }
}
