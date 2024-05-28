namespace ObjectProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj1 = 32;
            object obj2 = "Hello, World!";
            object obj3 = 3.14;
            Console.WriteLine(obj1.GetType()); // System.Int32
            Console.WriteLine(obj2.GetType()); // System.String
            Console.WriteLine(obj3.GetType()); // System.Double
        }
    }
}
