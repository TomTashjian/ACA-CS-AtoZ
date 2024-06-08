using System.ComponentModel;
using System.Numerics;
using System;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 11: Rock, Paper, Scissors Game
            // Objective: Implement a simple Rock, Paper, Scissors game.
            // Task: Write a program where the user plays Rock, Paper, Scissors against the computer.The computer randomly selects one of the options, and the user inputs their choice.The program then determines the winner.

            Random random = new Random();
            string[] rockPaperScissors = { "Rock", "Paper", "Scissors" };
            string computerSelection;
            string userSelection;

            Console.WriteLine("Welcome to Rock, Paper, Scissors Game!");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please type \"Rock\" or \"Paper\" or \"Scissors\" (\"Exit\" to quit):");
                userSelection = Console.ReadLine();
                computerSelection = rockPaperScissors[random.Next(0, 3)];
                
                if (string.IsNullOrEmpty(userSelection))
                {
                    Console.WriteLine("Invalid input");
                }
                else if (userSelection == "Rock")
                {
                    if (computerSelection == "Rock")
                    {
                        Console.WriteLine("draw!");
                    }
                    if (computerSelection == "Paper")
                    {
                        Console.WriteLine("you lost");
                    }
                    if (computerSelection == "Scissors")
                    {
                        Console.WriteLine("you won!");
                    }
                }
                else if (userSelection == "Paper")
                {
                    if (computerSelection == "Rock")
                    {
                        Console.WriteLine("you won!");
                    }
                    if (computerSelection == "Paper")
                    {
                        Console.WriteLine("draw!");
                    }
                    if (computerSelection == "Scissors")
                    {
                        Console.WriteLine("you lost");
                    }
                }
                else if (userSelection == "Scissors")
                {
                    if (computerSelection == "Rock")
                    {
                        Console.WriteLine("you lost");
                    }
                    if (computerSelection == "Paper")
                    {
                        Console.WriteLine("you won!");
                    }
                    if (computerSelection == "Scissors")
                    {
                        Console.WriteLine("draw!");
                    }
                }
                else if (userSelection == "Exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
                Console.WriteLine(computerSelection);
            }

        }
    }
}
