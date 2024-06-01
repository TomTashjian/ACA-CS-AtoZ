namespace Task1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1.4: Calculate Year of Birth
            // Objective: Create a console application that asks the user for their age and calculates their year of birth.

            Console.Write("Enter your age: ");
            string? age = Console.ReadLine();
            if (string.IsNullOrEmpty(age) || string.IsNullOrWhiteSpace(age))
                Console.WriteLine("you did not enter age");
            else
            {
                try
                {
                    Console.WriteLine("You are born in {0}", DateTime.Now.Year - int.Parse(age));
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid age!");
                }
            }
        }
    }
}
