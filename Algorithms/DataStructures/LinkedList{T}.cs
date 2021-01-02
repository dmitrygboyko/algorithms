using System;
using System.Collections.Generic;

namespace Algorithms.DataStructures
{
    public class LinkedList<T>
    {
        LinkedListNode<T> head;


        public LinkedListNode<T> Find(T value)
        {
            var current = head;
            EqualityComparer<T> comparer = EqualityComparer<T>.Default;

            while (current != null)
            {
                if (comparer.Equals(current.Data, value))
                {
                    return current;
                }

                current = current.Next;
            }

            return default;
        }

        public void Insert(T value)
        {
            var insertedNode = new LinkedListNode<T>(value);

            if (head != null)
            {
                insertedNode.Next = head;
            }

            head = insertedNode;
        }

        public void Delete(T value)
        {
            var nodeToDelete = Find(value);

            if (nodeToDelete == null)
            {
                throw new InvalidOperationException("Can't find item to delete");
            }

            Delete(nodeToDelete);
        }

        public void Delete(LinkedListNode<T> node)
        {
            if (node == head)
            {
                head = node.Next;
            }
            else
            {
                var parentNode = GetPrevious(node);

                if (parentNode == null)
                {
                    throw new InvalidOperationException("Node to delete must have a parent node");
                }

                parentNode.Next = node.Next;
            }
        }

        public T Min()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Linked list is empty");
            }

            var current = head.Next;
            var min = head.Data;
            var comparer = Comparer<T>.Default;

            while(current != null)
            {
                if (comparer.Compare(current.Data, min) < 0)
                {
                    min = current.Data;
                }

                current = current.Next;
            }

            return min;
        }

        public T Max()
        {
            if(IsEmpty)
            {
                throw new InvalidOperationException("Linked list is empty");
            }

            var current = head.Next;
            var max = head.Data;
            var comparer = Comparer<T>.Default;

            while (current != null)
            {
                if (comparer.Compare(current.Data, max) > 0)
                {
                    max = current.Data;
                }

                current = current.Next;
            }

            return max;
        }

        public bool IsEmpty => head == null;

        LinkedListNode<T> GetPrevious(LinkedListNode<T> linkedListNode)
        {
            var current = head;

            while (current != null && current.Next != linkedListNode)
            {
                current = current.Next;
            }

            return current;
        }
    }
}
