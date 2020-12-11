using Xunit;
using Algorithms.Sorting;

namespace Tests
{
    public class SortingTests
    {
        [Fact]
        public void SelectionSort()
        {
            var array = new int[] { 6, 5, 4, 3, 212, 1, 32, 2 };
            Selection.Sort(array);

            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 32, 212 }, array);
        }

        [Fact]
        public void InsertionSort()
        {
            var array = new int[] { 6, 5, 4, 3, 212, 1, 32, 2 };
            Insertion.Sort(array);

            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 32, 212 }, array);
        }


        [Fact]
        public void MergeSort()
        {
            var array = new int[] { 6, 5, 4, 3, 212, 1, 32, 2 };
            Merge.Sort(array);

            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 32, 212 }, array);
        }

        [Fact]
        public void QuickSort()
        {
            var array = new int[] { 6, 5, 4, 3, 212, 1, 32, 2 };
            Quick.Sort(array);

            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 32, 212 }, array);
        }
    }
}
