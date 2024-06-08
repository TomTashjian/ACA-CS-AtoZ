using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 9: Count Words in a Sentence
            // Objective: Use a loop to count the number of words in a sentence.
            // Task: Write a program that reads a sentence from the user and counts the number of words in the sentence.

            int count = 0;
            string inputString;

            Console.WriteLine("Please write a sentence:");
            inputString = Console.ReadLine();

            for (int i = 0; i < inputString.Length; ++i)
            {
                if (inputString[i] == ' ')
                {
                    count++;
                }
            }

            Console.WriteLine(++count);
        }
    }
}
