using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 9: switch with Fall - through
            // Create a variable level and assign it a value between 1 and 3.
            // Use a switch statement to print messages for each level:
            // Level 1: "Level 1: Beginner"
            // Level 2: "Level 2: Intermediate"
            // Level 3: "Level 3: Advanced"
            // For any other value, print "Invalid level".

            int level = 3; 

            switch (level)
            {
                case 1:
                    Console.WriteLine("Level 1: Beginner");
                    break;
                case 2:
                    Console.WriteLine("Level 2: Intermediate");
                    break;
                case 3:
                    Console.WriteLine("Level 3: Advanced");
                    break;
                default: 
                    Console.WriteLine("Invalid level");
                    break;
            }
        }
    }
}
