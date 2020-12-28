using System;
namespace Algorithms.DataStructures
{
    public class Stack
    {
        const int defaultStackLength = 4;
        const int defaultGrowthFactor = 2;

        int currentPosition = -1;
        int size = 0;
        int growthFactor;
        object[] array;

        public Stack(int stackCapacity = defaultStackLength, int growthFactor = defaultGrowthFactor)
        {
            if(stackCapacity <= 0)
            {
                throw new ArgumentException($"{nameof(stackCapacity)} must be greater than zero");
            }

            if (growthFactor <= 1)
            {
                throw new ArgumentException($"{nameof(growthFactor)} must be greater than one");
            }

            array = new object[stackCapacity];
            this.growthFactor = growthFactor;
        }

        public void Push(object item)
        {
            if (size == array.Length)
            {
                ResizeArray();
            }

            array[++currentPosition] = item;
            size++;
        }

        public object Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            var currentItem = array[currentPosition--];
            size--;

            return currentItem;
        }

        public object Peek()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return array[currentPosition];
        }

        public bool IsEmpty => size == 0;

        void ResizeArray()
        {
            if (size > 0)
            {
                var newArrayLength = array.Length * growthFactor;
                var newArray = new object[newArrayLength];

                Array.Copy(array, newArray, array.Length);
                array = newArray;
            }
        }
    }
}
