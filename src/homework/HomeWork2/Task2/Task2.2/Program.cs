using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace Task2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 2.2: Clear the Console
            // Objective: Create a console application that writes a message to the console, waits for user input, and then clears the console.
            Console.WriteLine("Type any key:");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
