using System.Runtime.Intrinsics.X86;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 3: Nested if Statements
            // Create a variable number and assign it a value.
            // Use nested if statements to check the range of the number:
            // If number is greater than 0, check if it is less than 50.
            // Print appropriate messages for each range

            int number = 25;

            if (number > 0)
            {
                if (number < 10)
                {
                    Console.WriteLine("number is within the range [0 - 10]");
                }
                if (number < 20)
                {
                    Console.WriteLine("number is within the range [0 - 20]");
                }
                if (number < 30)
                {
                    Console.WriteLine("number is within the range [0 - 30]");
                }
                if (number < 40)
                {
                    Console.WriteLine("number is within the range [0 - 40]");
                }
                if (number < 50) 
                {
                    Console.WriteLine("number is within the range [0 - 50]");
                }
            }
        }
    }
}
