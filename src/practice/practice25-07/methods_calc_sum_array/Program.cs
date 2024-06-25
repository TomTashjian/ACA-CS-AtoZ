namespace methods_calc_sum_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter how many numbers you want to calculate sum on:");
            int.TryParse(Console.ReadLine(), out int Count);

            Console.WriteLine($"Please enter {Count} number(s) to calculate their sum:");
            int[] numbers = new int[Count];

            for (int i = 0; i < Count; ++i)
            {
                int.TryParse(Console.ReadLine(), out numbers[i]);
            }

            Console.WriteLine("sum = " + SumArray(numbers));
        }

        static int SumArray(int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; ++i)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
