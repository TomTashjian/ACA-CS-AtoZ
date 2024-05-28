namespace DecimalProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal d1 = 12.34m;
            decimal d2 = 12.34m;
            decimal d3 = d1 + d2;
            Console.WriteLine(d3); // 24.68
        }
    }
}
