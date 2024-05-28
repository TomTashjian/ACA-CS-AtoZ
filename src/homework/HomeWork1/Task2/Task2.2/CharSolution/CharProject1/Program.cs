namespace CharProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c1 = 'a';
            char c2 = 'b';
            Console.WriteLine("c1 = {0}\nc2 = {1}", c1, c2);
            Console.WriteLine(c1 + c2); // 195
            Console.WriteLine($"{c1}{c2}"); // ab
        }
    }
}
