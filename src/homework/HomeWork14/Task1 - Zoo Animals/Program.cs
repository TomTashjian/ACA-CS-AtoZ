/*
Zoo Animals:
At a zoo, each enclosure holds different animals (attractions).
IEnumerable acts like a zookeeper who introduces you to one animal at a time (using an IEnumerator).
You observe each animal (access its properties) without overcrowding the entire zoo.
 */

using System.Collections;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalCollection animalCollection = new AnimalCollection { Name = "Lion" };
            animalCollection
                .Add(new AnimalCollection { Name = "Tiger" })
                .Add(new AnimalCollection { Name = "Bear" });

            Zookeeper zoo = new Zookeeper(animalCollection);

            foreach (AnimalCollection animal in zoo)
            {
                Console.WriteLine(animal.Name);
            }

            foreach (AnimalCollection animal in zoo)
            {
                Console.WriteLine(animal.Name);
            }

        }
    }
}
