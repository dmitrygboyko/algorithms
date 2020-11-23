using System;
namespace Algorithms.Sorting
{
    public static class SelectionSort
    {
        public static void Sort(int[] array)
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                var min = i;

                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    var temp = array[i];
                    array[i] = array[min];
                    array[min] = temp;
                }
            }
        }
    }
}
