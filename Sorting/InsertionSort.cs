using System;
namespace Algorithms.Sorting
{
    public class Insertion
    {
        public static void Sort(int[] array)
        {
            for(var i = 1; i < array.Length; i++)
            {
                var j = i;

                while(j > 0 && array[j] < array[j - 1])
                {
                    var temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    j--;
                }
            }
        }
    }
}
