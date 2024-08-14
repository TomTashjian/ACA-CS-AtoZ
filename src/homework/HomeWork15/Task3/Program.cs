/*
Generate the Fibonacci sequence using yield return.
Create an iterator that produces Fibonacci numbers up to a specified limit.
Example: foreach (var fib in FibonacciSequence(100)) { Console.Write(fib + " "); }.
*/

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var fib in new FibonacciSequence(100))
            {
                System.Console.Write(fib + " ");
            }
        }
    }
}
