using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Threading.Channels;

namespace Task2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 2.4: Beep Sound
            // Objective: Create a console application that makes the console beep.
            Console.WriteLine("Hi, enjoy the beep sound! :)");
            Console.Beep();
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey(true);
        }
    }
}