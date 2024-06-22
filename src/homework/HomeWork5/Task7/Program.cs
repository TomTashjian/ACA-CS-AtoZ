using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 7: Complex Nested if Statements
            // Create variables age and hasLicense.
            // Use nested if statements to check if:
            // age is greater than or equal to 18.
            // hasLicense is true.
            // Print "Can drive" if both conditions are met; otherwise, print appropriate messages.

            int age = 18;
            bool hasLicense = false;

            if ( age >= 18 )
            {
                if ( hasLicense )
                {
                    Console.WriteLine("Can drive!");
                }
                else 
                {
                    Console.WriteLine("Can not drive");
                }
            }
            else
            {
                Console.WriteLine("Can not drive");
            }
        }
    }
}
