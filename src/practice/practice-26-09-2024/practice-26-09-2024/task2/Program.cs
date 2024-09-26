namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var filteredInts = Filter(ints, i => i % 4 == 0);

            foreach (int i in filteredInts)
            {
                Console.WriteLine(i);
            }
        }
        static IEnumerable<int> Filter(IEnumerable<int> ints, Predicate<int> predicate)
        {
            foreach (int i in ints)
            {
                if (predicate(i))
                {
                    yield return i;
                }
            }
        }
    }
}
