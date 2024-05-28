namespace NintProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            nint n1 = nint.MaxValue;
            Console.WriteLine(n1);
            Console.WriteLine(nint.MinValue);
            Console.WriteLine(nint.Size); // 8 (Bytes) = 64 bits (depends on the process)
        }
    }
}
