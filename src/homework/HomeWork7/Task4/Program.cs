using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 4: Check Palindrome
            // Objective: Use a loop to check if a string is a palindrome.
            // Task: Write a program that reads a string from the user and checks if it is a palindrome.

            // Solution 1
            //string inputString;
            //string inputStringBackwards;

            //Console.WriteLine("Please enter a string to check if it is a palindrome:");
            //inputString = Console.ReadLine();
            //inputStringBackwards = string.Concat(inputString.Reverse());

            //Console.WriteLine(inputStringBackwards);

            //if (inputString == inputStringBackwards)
            //{
            //    Console.WriteLine("Palindrome!");
            //}
            //else
            //{
            //    Console.WriteLine("Not a Palindrome");
            //}

            // Solutnion 2
            string inputString;
            StringBuilder sbReverse = new StringBuilder();

            Console.WriteLine("Please enter a string to check if it is a palindrome:");
            inputString = Console.ReadLine();
            sbReverse.Append(inputString);

            for (int i = 0; i < inputString.Length; ++i)
            {
                sbReverse[i] = inputString[(inputString.Length - 1) - i];
            }

            Console.WriteLine(sbReverse);

            if (inputString == sbReverse.ToString())
            {
                Console.WriteLine("Palindrome!");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }
        }
    }
}
