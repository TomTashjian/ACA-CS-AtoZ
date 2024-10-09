namespace methods_array_minimum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Count = 10;

            int[] nums = new int[Count];

            Random rand = new Random();

            // Initialize array
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1, 100);
            }
            
            // Print Array
            Print(nums);

            // Print Minimum
            Console.WriteLine("integer array minimum = " + GetMin(nums));

        }

        static int GetMin(int[] nums)
        {
            int min = nums[0];

            for(int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }

            return min;
        }

        static void Print(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
