namespace methods_reverse_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Count = 5;

            int[] nums = new int[Count];
            
            // Initialize array
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 1;
            }

            Print(nums);

            nums = Reverse(nums);

            Print(nums);

        }

        static int[] Reverse(int[] ints) 
        {
            int[] reverseArray = new int[ints.Length];

            for(int i = 0; i < ints.Length; i++)
            {
                reverseArray[i] = ints[(ints.Length - i) - 1];
            }

            return reverseArray;
        }

        static void Print(int[] ints)
        {
            for(int i = 0;i < ints.Length;i++)
            {
                Console.Write(ints[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
