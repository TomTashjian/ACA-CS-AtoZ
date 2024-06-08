using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 10: Number Guessing Game
            // Objective: Implement a simple number guessing game.
            // Task: Write a program where the computer randomly selects a number between 1 and 100.
            // The user has to guess the number.The program should provide feedback if the guess is too high or too low until the user guesses the correct number.

            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 100);
            int inputNumber = 0;

            Console.WriteLine("Guess the number between 1 to 100:");

            while (inputNumber != randomNumber)
            {
                int.TryParse(Console.ReadLine(), out inputNumber);
                if (inputNumber < randomNumber)
                {
                    Console.WriteLine("Try again, your number is too low");
                }

                if (inputNumber > randomNumber)
                {
                    Console.WriteLine("Try again, your number is too high");
                }
            }

            Console.WriteLine("Congratulations! you guessed it!");
        }
    }
}
