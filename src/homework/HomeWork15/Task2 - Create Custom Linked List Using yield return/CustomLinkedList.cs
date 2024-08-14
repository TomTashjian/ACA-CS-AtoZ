/*
Create a custom linked list using yield return.
Implement methods like Add, Remove, and Contains.
Example: var myList = new CustomLinkedList<int>(); myList.Add(10); myList.Add(20); myList.Add(30);.
 */

using System.Collections;
using System.Runtime.CompilerServices;

namespace Task2
{
    public class CustomLinkedList<T> : IEnumerable<T> where T : struct
    {
        public T Value { get; set; }
        public CustomLinkedList<T>? First;
        public CustomLinkedList<T>? Next;
        public CustomLinkedList<T>? Previous;
        public CustomLinkedList<T>? Last;

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = First; i != null; i = i.Next)
            {
                yield return i.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Adds a new node at the end of the list
        /// </summary>
        public void Add(T value)
        {
            if (First == null)
            {
                Value = value;
                First = this;
                Last = this;
            }
            else
            {
                var newNode = new CustomLinkedList<T> { Value = value };
                newNode.First = this.First; // store First node reference in new node
                var temp = this.First;
                while (temp.Next != null)
                {
                    temp.Last = newNode; // mark new node as Last on all nodes
                    temp = temp.Next;
                }
                temp.Next = newNode;
                temp.Last = newNode;
                newNode.Previous = temp;
                newNode.Last = newNode;
            }
        }

        /// <summary>
        /// Removes first occurrence of a node with the specified value
        /// </summary>
        public bool Remove(T value)
        {
            if (First == null)
            {
                return false;
            }
            else if (!Contains(value))
            {
                return false;
            }
            else
            {
                if (Find(value) == null)
                {
                    return false;
                } 
                else if (Find(value) == First)
                {
                    First = First.Next;
                    First.Previous = null;
                    return true;
                }
                else if (Find(value) == Last)
                {
                    Last = Last.Previous;
                    Last.Next = null;
                    return true;
                }
                else
                {
                    var found = Find(value);
                    found.Previous.Next = found.Next;
                    found.Next.Previous = found.Previous;
                    return true;
                }
                
            }
        }
        public bool Contains(T Value)
        {

            foreach (var item in this)
            {
                if (item.Equals(Value))
                {
                    return true;
                }
            }
            return false;
        }

        private CustomLinkedList<T>? Find(T value)
        {
            for (var i = First; i != null; i = i.Next)
            {
                if (i.Value.Equals(value))
                {
                    return i;
                }
            }
            return null;
        }
    }
}