/*
Task: City Attractions Enumerator
Background:
    Imagine you’re building a city guide app. Each city has attractions (e.g., museums, parks, restaurants).
    You want to create an efficient way to iterate through these attractions without loading them all into memory at once(get it by one at each itaration).
Instructions:
    Implement an Attraction class with properties like Name, Description, and Category.
    Create a CityAttractions class that implements IEnumerable<Attraction>.
    The CityAttractions class should have an internal list of attractions.
    When iterating through the city attractions, it should provide one attraction at a time (like turning pages in a guidebook).
    Implement the necessary methods to support iteration (hint: GetEnumerator()).
Task:
    Write a C# program that demonstrates the usage of your CityAttractions class.
    Add a few attractions to the list (e.g., “Central Park,” “Metropolitan Museum of Art,” “Times Square”).
    Iterate through the attractions and print their names and descriptions.
Bonus:
    Implement a custom enumerator (class) that adheres to the IEnumerator<Attraction> interface.
    Handle edge cases (e.g., resetting the enumerator).
 */

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CityAttractions cityAttractions = new CityAttractions();
            Console.WriteLine("Here are the list of City Attractions:");
            foreach (Attraction attraction in cityAttractions)
            {
                Console.WriteLine($"* {attraction.Name}:\n  Description - {attraction.Description}\n  Category - {attraction.Category}");
            }
        }
    }
}
