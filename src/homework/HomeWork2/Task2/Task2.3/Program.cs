using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Threading.Channels;

namespace Task2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 2.3: Change Console Title
            // Objective: Create a console application that changes the title of the console.
            Console.Title = "MY CONSOLE APP";
            Console.WriteLine("Hello World!");
            Console.ReadKey(true);
        }
    }
}