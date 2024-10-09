namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>() {1, 2, 3 };
            List<string> strings = new List<string> { "abc", "def", "ghi" };
            var result = ints.MyContains(1);
            Console.WriteLine(result);
            var result2 = strings.MyContains("ab");
            Console.WriteLine(result2);
        }
    }

    public static class MyLinq
    {
        public static bool MyContains<T>(this IEnumerable<T> values, T value)
        {
            if (value == null)
            {
                return false; 
            }

            foreach (var item in values) 
            {
                if (value.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
