using System;

namespace Algorithms.DataStructures
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T data)
        {
            Data = data ?? throw new ArgumentNullException(nameof(data));
        }

        public T Data { get; }
        public LinkedListNode<T> Next { get; set; }
    }
}
