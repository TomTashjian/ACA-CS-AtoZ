namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var numbers = ints.Filter(i => i % 4 == 0);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
    public static class Helper
    {
        public static IEnumerable<int> Filter(this IEnumerable<int> ints, Predicate<int> predicate)
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
