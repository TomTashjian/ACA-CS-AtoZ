using System.Runtime.Intrinsics.X86;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 8: if with Logical Operators
            // Create variables temperature and isRaining.
            // Use an if statement with logical operators to check if:
            // temperature is greater than 20 and isRaining is false.
            // Print "Good weather for a walk" if the condition is met; otherwise, print "Stay indoors".

            double temperature = 20.1;
            bool isRaining = false;

            if (!isRaining &&  temperature > 20)
            {
                Console.WriteLine("Good weather for a walk");
            }
            else
            {
                Console.WriteLine("Stay indoors");
            }
        }
    }
}
