/*
Create a custom linked list using yield return.
Implement methods like Add, Remove, and Contains.
Example: var myList = new CustomLinkedList<int>(); myList.Add(10); myList.Add(20); myList.Add(30);.
 */

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var myList = new CustomLinkedList<int>
            {
                // calls Add() method after calling the constructor !!WOW!!
                10,
                20,
                30,
                40,
                50
            };
            myList.Add(60); // redundant

            Console.WriteLine($"Here's a list of numbers:");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            int valueToRemove = 0;
            Console.WriteLine("\nSpecfiy a value to remove:");
            int.TryParse(Console.ReadLine(), out valueToRemove); 

            Console.WriteLine($"\nContains {valueToRemove}: " + myList.Contains(valueToRemove));
            
            var result = myList.Remove(valueToRemove);
            Console.WriteLine($"Remove {valueToRemove}: " + result + "\n");

            if (result)
            {
                Console.WriteLine($"Here's the list after Remove:");

                foreach (var item in myList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
               Console.WriteLine($"Value {valueToRemove} not found in the list.");
            }
        }
    }
}
