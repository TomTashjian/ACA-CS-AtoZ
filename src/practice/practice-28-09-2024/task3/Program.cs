namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pets = MyData.pets;
            var persons = MyData.persons;
        }
    }

    public static class MyLinq
    {
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> Collection, Func<T, bool> predicate)
        {
            IEnumerable<T> filtertedCollection;
            foreach (var item in Collection)
            {
                if (predicate(item))
                {
                }
            }
        }
    }
}
