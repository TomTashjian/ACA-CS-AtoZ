// Explicit Interface Implementation:
// Define an interface IAnimal with methods Eat() and Sleep().
// Create a class Dog that implements IAnimal. Implement the methods explicitly (using the IAnimal. prefix).
// Create a Dog object and call the Eat() and Sleep() methods.

namespace Task2___Explicit_Interface_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dog dog = new Dog();
            // dog.Eat(); // error
            // dog.Sleep(); //error
            
            IAnimal animal = new Dog();
            animal.Eat();
            animal.Sleep();
        }
    }
}
