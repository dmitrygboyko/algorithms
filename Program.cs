using System;
using Algorithms.Sorting;

namespace algos
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[]{ 6, 5, 4, 3, 212, 1, 32, 2 };

            Insertion.Sort(array);
            Print(array);

            Console.ReadLine();
        }

        

        static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
