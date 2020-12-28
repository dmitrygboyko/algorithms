using System;
namespace Algorithms.DataStructures
{
    public class Queue
    {
        const int defaultQueueSize = 12;
        const int defaultGrowthFactor = 2;

        object[] array;
        int size;
        int tail;
        int head;
        int growthFactor;

        public Queue() : this(defaultQueueSize, defaultGrowthFactor)
        {
        }

        public Queue(int queueCapacity, int growthFactor)
        {
            if (queueCapacity <= 0)
            {
                throw new ArgumentException($"{nameof(queueCapacity)} must be greater than zero");
            }

            if (growthFactor <= 1)
            {
                throw new ArgumentException($"{nameof(growthFactor)} must be greater than one");
            }

            array = new object[queueCapacity];
            this.growthFactor = growthFactor;
        }

        public void Enqueue(object item)
        {
            if (size == array.Length)
            {
                ResizeArray();
            }
                
            array[tail] = item;
            tail = (tail + 1) % array.Length;
            size++;
        }

        public object Dequeue ()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            var dequeuedItem = array[head];
            array[head] = null;
            head = (head + 1) % array.Length;
            size--;

            return dequeuedItem;
        }

        public object Peek()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return array[head];
        }

        public bool IsEmpty => size == 0;

        void ResizeArray()
        {
            var capacity = array.Length * growthFactor;
            var newArray = new object[capacity];

            if (size > 0)
            {
                if (head < tail)
                {
                    Array.Copy(array, head, newArray, 0, size);
                }
                else
                {
                    Array.Copy(array, head, newArray, 0, array.Length - head);
                    Array.Copy(array, 0, newArray, array.Length - head, tail);
                }

                array = newArray;
                head = 0;
                tail = size;
            }
        }
    }
}
