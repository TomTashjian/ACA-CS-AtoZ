namespace DynamicProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic dyn1= 3.14e100;
            Console.WriteLine(dyn1.GetType()); // System.Double
            Console.WriteLine(dyn1);
        }
    }
}
