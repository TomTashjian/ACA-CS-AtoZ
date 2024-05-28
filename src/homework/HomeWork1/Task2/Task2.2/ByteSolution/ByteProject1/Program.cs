namespace ByteProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 1;
            byte n2 = 2;
            //byte n3 = n1 + n2; // Error: Cannot implicitly convert type 'int' to 'byte'
            byte n3 = (byte)(n1 + n2);
            Console.WriteLine("n1 = {0}\nn2 = {1}", n1, n2);
            Console.WriteLine("n3 = n1 + n2 = " + n3);
        }
    }
}
