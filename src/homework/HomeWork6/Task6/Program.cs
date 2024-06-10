using System.ComponentModel;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 6: Find Factorial
            // Objective: Calculate the factorial of a number using a loop.
            // Task: Write a program that reads an integer N from the user and prints the factorial of N.

            int N = 0;
            Console.WriteLine("Please enter a number to calculate its factorial: ");
            int.TryParse(Console.ReadLine(), out N);
            int factorial = 1;

            Console.WriteLine("[calculation details]");
            for (int i = 1; i <= N; ++i)
            {
                Console.Write($"{i}! = {factorial} x {i} = ");
                factorial *= i;
                Console.WriteLine(factorial);
            }

            Console.WriteLine("[result]");
            Console.WriteLine("{0}! = {1}", N, factorial);
        }
    }
}
