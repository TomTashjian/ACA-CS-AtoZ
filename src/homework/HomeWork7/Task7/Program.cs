using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 7: Sum of Even Digits
            // Objective: Use a loop to find the sum of even digits of a number.
            // Task: Write a program that reads an integer from the user and prints the sum of its even digits.

            string inputNumber;
            int sum = 0;

            Console.WriteLine("Please enter a number:");
            inputNumber = Console.ReadLine();

            for (int i = 0; i < inputNumber.Length; i++)
            {
                if (int.Parse(inputNumber[i].ToString()) % 2 == 0)
                {
                    sum += int.Parse(inputNumber[i].ToString());
                }
            }

            Console.WriteLine("sum of even numbers = " + sum);
        }
    }
}
