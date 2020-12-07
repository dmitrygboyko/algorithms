using System;
using Algorithms.Sorting;

namespace algos
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[]{ 6, 5, 4, 3, 2, 1 };

            Selection.Sort(array);
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
