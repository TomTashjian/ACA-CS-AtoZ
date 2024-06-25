using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Buffers.Text;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and Assign Enum Constants:
            // Declare an enum representing different weather conditions(e.g., Sunny, Cloudy, Rainy).
            // Assign one of its constants to a variable and print a message based on the weather.

            var weatherCondition = WeatherConditions.Sunny;
            // string weatherName = (string)WeatherConditions.Sunny; //error
            string weatherConditionsEnumToString = WeatherConditions.Sunny.ToString();

            Console.WriteLine(weatherCondition);
            Console.WriteLine(weatherConditionsEnumToString);
        }

        enum WeatherConditions
        {
            Sunny,
            Cloudy,
            Rainy
        }
    }
}
