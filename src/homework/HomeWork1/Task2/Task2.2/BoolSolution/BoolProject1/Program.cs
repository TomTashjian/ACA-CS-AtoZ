namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b1 = true;
            bool b2 = false;
            Console.WriteLine("b1 = {0}\nb2 = {1}", b1, b2);
            // int i1 = b1 + b2; // Error: Operator '+' cannot be applied to operands of type 'bool' and 'bool'
        }
    }
}
