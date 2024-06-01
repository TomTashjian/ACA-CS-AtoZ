namespace Task1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1.2: User Information (Same Line)
            // Objective: Create a console application that asks the user for their name, surname, age, and profession and prints them in the console on the same line.

            Console.Write("Please enter your name: ");
            string? name = Console.ReadLine();
            Console.Write("Please enter your surname: ");
            string? surname = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string? age = Console.ReadLine();
            Console.Write("Please enter your profession: ");
            string? professoin = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}! You are {2} years old and you are a {3}", name, surname, age, professoin);
        }
    }
}
