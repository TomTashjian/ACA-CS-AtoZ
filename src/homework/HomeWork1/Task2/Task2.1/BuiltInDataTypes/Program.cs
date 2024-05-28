namespace BuiltInDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //built-in value types
            bool b1 = true;
            byte n1 = 255;
            sbyte n2 = -128;
            char ch1 = 'A';
            decimal dec1 = -1.23e12m;
            double d2 = -1.23e45;
            float f1 = -1.23e12f;
            int n3 = -1;
            uint n4 = 123;
            nint n5 = -1;
            nuint n6 = 123;
            long n7 = -1;
            ulong n8 = 123;
            short n9 = -1;
            ushort n10 = 123;

            //built-in reference types
            object o1 = 1;
            string s1 = "Hello, World!";
            dynamic d3 = 123;
        }
    }
}
