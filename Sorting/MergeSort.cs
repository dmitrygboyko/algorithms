using System;
namespace Algorithms.Sorting
{
    public class Merge
    {
        public static void Sort(int[] array)
        {
            MergeSort(array, 0, array.Length - 1);
        }


        private static void MergeSort(int[] array, int low, int high)
        {
            if (low >= high)
            {
                return;
            }

            int middle = (low + high) / 2;
            MergeSort(array, low, middle);
            MergeSort(array, middle + 1, high);
            MergeSubArrays(array, low, middle, high);
        }

        private static void MergeSubArrays(int[] array, int left, int middle, int right)
        {
            var leftLength = middle - left + 1;
            var rightLength = right - middle;

            var leftArray = new int[leftLength];
            var rightArray = new int[rightLength];

            for (var l = 0; l < leftLength; l++)
            {
                leftArray[l] = array[left + l];
            }

            for (var r = 0; r < rightLength; r++)
            {
                rightArray[r] = array[middle + r + 1];
            }

            var i = 0;
            var j = 0;
            var k = left;

            while (i < leftLength && j < rightLength)
            {
                if (leftArray[i] < rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                    k++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                    k++;
                }
            }

            while (i < leftLength)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < rightLength)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}