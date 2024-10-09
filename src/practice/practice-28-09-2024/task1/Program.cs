namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> odds = new List<int> { 1, 3, 5, 7, 9 };
            List<int> evens = new List<int> { 2, 4, 6, 8, 10 };
            bool isAnyEven = odds.MyAny(x => x % 2 == 0);
            bool isAnyEven1 = evens.MyAny(x => x % 2 == 0);
            bool isAllEven = evens.MyAll(x => x % 2 == 0);
            Console.WriteLine(isAnyEven);
            Console.WriteLine(isAnyEven1);
            Console.WriteLine(isAllEven);
        }
    }

    public static class MyLinq
    {
        public static bool MyAny(this IEnumerable<int> ints, Func<int, bool> conditionalFunc)
        {
            foreach (var i in ints)
            {
                if (conditionalFunc(i))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool MyAll(this IEnumerable<int> ints, Func<int, bool> conditionalFunc)
        { 
            foreach (var i in ints)
            {
                if (!conditionalFunc(i))
                {
                    return false;
                }
            }
            return true;
        }


    }
}
