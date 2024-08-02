using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2___Explicit_Interface_Implementation
{
    public class Dog : IAnimal
    {
        void IAnimal.Eat()
        {
            Console.WriteLine("Eat like a Dog");
        }

        void IAnimal.Sleep()
        {
            Console.WriteLine("Sleep like a Dog");
        }
    }
}
