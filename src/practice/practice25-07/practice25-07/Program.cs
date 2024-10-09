namespace practice25_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("please enter a number");
            int.TryParse(Console.ReadLine(), out number);

            checkParity(number);

        }

        static void checkParity(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("odd number");
            }
        }
    }
}
