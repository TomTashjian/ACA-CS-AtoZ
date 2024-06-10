using System.Collections.Generic;
using System.ComponentModel;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 7: Fibonacci Sequence
            // Objective: Generate Fibonacci sequence using a loop.
            // Task: Write a program that reads an integer N from the user and prints the first N numbers in the Fibonacci sequence.

            int N = 0;
            Console.WriteLine("Please enter a number (N) to generate the first N numbers in the Fibonacci sequence: ");
            int.TryParse(Console.ReadLine(), out N);
            
            int Fibonacci_0 = 0;
            int Fibonacci_1 = 1;
            int Fibonacci = 0;
            Console.Write(Fibonacci_0 + ", ");
            Console.Write(Fibonacci_1 + ", ");

            for (int i = 0; i < (N - 2); ++i)
            {
                Fibonacci = Fibonacci_0 + Fibonacci_1;
                Fibonacci_0 = Fibonacci_1;
                Fibonacci_1 = Fibonacci;
                
                Console.Write(Fibonacci);
                if (i == N - 3)
                {
                }
                else
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
