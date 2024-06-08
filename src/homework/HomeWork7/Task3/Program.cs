using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 3: Average of Numbers
            // Objective: Use a loop to calculate the average of a set of numbers.
            // Task: Write a program that reads 50 integers from the user and calculates their average.

            int inputCount = 50;
            int[] userInputInts = new int[inputCount];
            int average = 0;
            int sum = 0;

            Console.WriteLine($"Please enter {inputCount} numbers:");

            for (int i = 0; i < inputCount; ++i)
            {
                userInputInts[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0;i < inputCount; ++i)
            {
                sum += userInputInts[i];
            }
            
            Console.WriteLine("average = {0}", average = sum / inputCount);

        }
    }
}
