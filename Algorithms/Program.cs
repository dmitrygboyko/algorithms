using System;
using Algorithms.Sorting;

namespace algos
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 5, 1, 3, 8, 4, 9, 2, 6 };

            Quick.Sort(array);
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
