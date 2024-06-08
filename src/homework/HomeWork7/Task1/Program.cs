using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Find the Largest Number
            // Objective: Use a loop to find the largest number in an array.
            // Task: Write a program that reads 10 integers from the user and finds the largest number among them.

            int numberOfInputs = 10;
            int[] ints = new int[numberOfInputs];
            int max = 0;

            Console.WriteLine($"Please enter {numberOfInputs} numbers:");

            for (int i = 0; i < numberOfInputs; ++i)
            {
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }

            max = ints[0];

            for (int i = 0; i < numberOfInputs; ++i)
            {
                if (ints[i] > max)
                { 
                    max = ints[i];
                }
            }

            Console.WriteLine("largest number is:" + max);

        }
    }
}
