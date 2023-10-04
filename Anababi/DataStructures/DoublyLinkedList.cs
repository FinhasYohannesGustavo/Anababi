using Anababi.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anababi.DataStructures
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedListNode<T> First;
        public DoublyLinkedListNode<T> Last;

        public int Count { get; private set; }

        public DoublyLinkedList()
        {
            First = null;
            Last = null;
            Count = 0;
        }
        public DoublyLinkedList(List<T> values)
        {
            foreach (T value in values)
            {
                AddLast(value);
            }
        }

        // Add a new element to the end of the list
        public void AddLast(T data)
        {
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(data);

            if (First == null)
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                newNode.Previous = Last;
                Last.Next = newNode;
                Last = newNode;
            }

            Count++;
        }

        // Remove the first occurrence of a given element
        public bool Remove(T data)
        {
            DoublyLinkedListNode<T> current = First;
            bool found = false;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, data))
                {
                    if (current.Previous != null)
                    {
                        current.Previous.Next = current.Next;
                    }
                    else
                    {
                        First = current.Next;
                    }

                    if (current.Next != null)
                    {
                        current.Next.Previous = current.Previous;
                    }
                    else
                    {
                        Last = current.Previous;
                    }

                    Count--;
                    found = true;
                }

                current = current.Next;
            }

            return found;
        }

        // Traverse the list from First to Last
        public IEnumerable<T> ForwardTraversal()
        {
            DoublyLinkedListNode<T> current = First;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        // Traverse the list from Last to First
        public IEnumerable<T> ReverseTraversal()
        {
            DoublyLinkedListNode<T> current = Last;

            while (current != null)
            {
                yield return current.Value;
                current = current.Previous;
            }
        }
    }


}
