/*
Advanced Challenge: Dependency Injection:
Create an interface ILogger with a method Log(string message).
Implement two classes: ConsoleLogger (logs to console) and FileLogger (logs to a file).
Create a service class that accepts an ILogger instance via constructor injection and uses it to log
 */

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoggerService consoleLoggerService = new LoggerService(new ConsoleLogger());
            consoleLoggerService.Log("Hello, World!");
            LoggerService fileLoggerService = new LoggerService(new FileLogger());
            fileLoggerService.Log("Hello, World!");
        }
    }
}
