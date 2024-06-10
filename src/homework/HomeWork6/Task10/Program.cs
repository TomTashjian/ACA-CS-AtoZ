using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 10: Sum of Digits
            // Objective: Calculate the sum of the digits of a number using a loop.
            // Task: Write a program that reads an integer from the user and prints the sum of its digits.

            string userInput;
            Console.Write("Please enter a number to calculate the sum of its digits: ");
            userInput = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                sum += int.Parse(userInput[i].ToString());
            }

            Console.WriteLine(sum);
        }
    }
}
