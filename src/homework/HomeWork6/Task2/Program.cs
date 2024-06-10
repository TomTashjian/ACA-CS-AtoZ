using System.Collections.Generic;
using System.ComponentModel;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 2: Sum of First N Natural Numbers
            // Objective: Calculate the sum of the first N natural numbers using a loop.
            // Task: Write a program that reads an integer N from the user and prints the sum of the first N natural numbers

            int N = 20;

            for (int i = 1; i <= N; ++i)
            {
                Console.WriteLine(i);
            }
        }
    }
}
