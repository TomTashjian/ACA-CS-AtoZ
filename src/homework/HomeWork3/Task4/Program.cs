namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "123";
            int i1 = int.Parse(s1);
            string s2 = "Hi";
            int i2;
            int.TryParse(s2, out i2);
            Console.WriteLine(i1);
            Console.WriteLine(i2);


        }
    }
}
