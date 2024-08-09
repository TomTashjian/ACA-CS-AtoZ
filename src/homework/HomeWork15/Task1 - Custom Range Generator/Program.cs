/*
Custom Range Generator:
Create a custom range generator using yield return.
The generator should take a start value and an end value and produce all integers in that range.
Example usage: foreach (var number in RangeGenerator(5, 10)) { Console.Write(number + " "); } should output 5 6 7 8 9 10
 */

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(var number in new RangeGenerator(5, 10))
            {
                Console.Write(number + " ");
            }
        }
    }
}
