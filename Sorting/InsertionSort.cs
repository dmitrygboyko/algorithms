namespace Algorithms.Sorting
{
    public class Insertion
    {
        public static void Sort(int[] array)
        {
            for(var i = 1; i < array.Length; i++)
            {
                var j = i;
                var currentValue = array[j];

                while(j > 0 && currentValue < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }

                array[j] = currentValue;
            }
        }
    }
}
