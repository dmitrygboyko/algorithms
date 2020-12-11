using System;
namespace Algorithms.Sorting
{
    public class Quick
    {
        public static void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort(int[] array, int low, int high)
        {
            if (low >= high)
            {
                return;
            }

            var pivot = Parition(array, low, high);
            Sort(array, low, pivot - 1);
            Sort(array, pivot + 1, high);
        }

        private static int Parition(int[] array, int low, int high)
        {
            var pivot = array[high];

            var i = low;
            var j = high;

            while (i < j)
            {
                if (array[i] > pivot)
                {
                    var temp = array[i];
                    array[i] = array[j - 1];
                    array[j] = temp;
                    j--;
                }
                else
                {
                    i++;
                }
            }

            array[j] = pivot;

            return j;
        }
    }
}
