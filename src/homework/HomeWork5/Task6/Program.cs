using System.Buffers.Text;
using System.Runtime.Intrinsics.X86;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 6: switch Statement with Strings
            // Create a variable command and assign it a value("start", "stop", "pause", "resume").
            // Use a switch statement to print appropriate messages based on the value of command.

            string command = "resume";

            switch (command)
            {
                case "start":
                    Console.WriteLine(command);
                    break;
                case "stop":
                    Console.WriteLine(command);
                    break;
                case "pause":
                    Console.WriteLine(command);
                    break;
                case "resume":
                    Console.WriteLine(command);
                    break;
                default:
                    Console.WriteLine("unimplemented case");
                    break;
            }
        }
    }
}
