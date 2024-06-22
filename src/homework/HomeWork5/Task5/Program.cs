using System.Runtime.Intrinsics.X86;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 5: switch Statement with Integers
            // Create a variable day and assign it a value between 1 and 7.
            // Use a switch statement to print the day of the week based on the value of day.

            int day = 2;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("invalid day number");
                    break;
            }
        }
    }
}
