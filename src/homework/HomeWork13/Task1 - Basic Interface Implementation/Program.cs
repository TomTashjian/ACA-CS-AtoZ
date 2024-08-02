// Basic Interface Implementation:
// Create an interface called IShape with a method CalculateArea().
// Implement this interface in classes for different shapes (e.g., Circle, Rectangle, Triangle). 
// Each class should provide its own implementation of the area calculation.
// Create instances of these shapes and calculate their areas.

using System.Drawing;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Circle circle = new Circle() { Radius = 2 };
            // Triangle triangle = new Triangle() { Base = 2, Height = 2 };
            // Rectangle rectangle = new Rectangle() { Length = 2, Width = 2 };
            // Console.WriteLine("Area of the Circle is: " + circle.CalculateArea());
            // Console.WriteLine("Area of the Rectangle is: " + rectangle.CalculateArea());
            // Console.WriteLine("Area of the Triangle is: " + triangle.CalculateArea());

            IShape[] shapes = { 
                new Circle() { Radius = 2 }, 
                new Triangle() { Base = 2, Height = 2 }, 
                new Rectangle() { Length = 2, Width = 2 } 
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Area of the {shape.GetType().Name} is: {shape.CalculateArea()}");
            }

        }
    }
}
