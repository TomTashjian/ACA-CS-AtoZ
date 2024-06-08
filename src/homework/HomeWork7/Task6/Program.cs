using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 6: Armstrong Number
            // Objective: Use loops to determine if a number is an Armstrong number.
            // Task: Write a program that reads an integer from the user and checks if it is an Armstrong number
            //       (a number that is equal to the sum of its own digits each raised to the power of the number of digits).

            int inputNumber = 0;
            int count = 0;
            int armstrong = 0;

            Console.WriteLine("Please enter a number to check if it is an Armstrong:");
            int.TryParse(Console.ReadLine(), out inputNumber);

            int temp = inputNumber;

            // digits count
            while (temp > 0)
            {
                temp = temp / 10;
                count++;
            }

            int decimalDigit = 0;
            int decimalDigitRaisedToCountPower = 0;
            int inputNumberCopy = inputNumber;
            
            // calculate Armstrong
            for (int i = 0; i < count; i++) 
            {
                // take one decimal digit
                decimalDigit = inputNumberCopy % 10;

                // reduce one digit for next iteration
                inputNumberCopy = inputNumberCopy / 10;

                // assign digit to calculate power
                decimalDigitRaisedToCountPower = decimalDigit;

                // calculate exponent (power) equal to the count
                for (int j = 0; j < (count - 1); j++)
                {
                    decimalDigitRaisedToCountPower *= decimalDigit;
                }

                armstrong += decimalDigitRaisedToCountPower;
            }

            Console.WriteLine(armstrong);

            if (armstrong == inputNumber)
            {
                Console.WriteLine("Your number is Armstrong!");
            }
            else
            {
                Console.WriteLine("Your number is not an Armstrong");
            }
        }
    }
}
