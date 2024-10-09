namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> filteredInts= new List<int>();

            filteredInts = Filter(ints, i => i % 4 == 0);
            
            foreach(int i in filteredInts) 
            {
                Console.Write(i + " ");
            }
        }

        static List<int> Filter(List<int> ints, Predicate<int> predicate)
        {
            List<int> filteredInts = new List<int>();
            foreach (int i in ints)
            {
                if (predicate(i))
                {
                    filteredInts.Add(i);
                }
            }
            return filteredInts;
        }
    }
}
