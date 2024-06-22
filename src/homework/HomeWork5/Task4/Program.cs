using System.Buffers.Text;
using System.Runtime.Intrinsics.X86;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 4: if-else if-else Ladder
            // Create a variable score and assign it a value.
            // Use an if-else if-else ladder to print grades based on the score:
            // >= 90: "A"
            // >= 80: "B"
            // >= 70: "C"
            // >= 60: "D"
            // < 60: "F"
            int score = 0;
            Console.WriteLine("Please enter a score [0, 100]:");
            int.TryParse(Console.ReadLine(), out score);

            if (score >= 90)
            {
                Console.WriteLine("A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
