namespace calc_sum_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter 2 numbers to calculate sum:");
            int.TryParse(Console.ReadLine(), out int number1);
            int.TryParse(Console.ReadLine(), out int number2);

            Console.WriteLine("sum = " + sum(number1, number2)); 
        }

        static int sum (int a, int b)
        {
            return a + b;
        }
    }
}
