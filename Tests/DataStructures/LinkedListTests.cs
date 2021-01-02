using Xunit;
using Algorithms.DataStructures;

namespace Tests.DataStructures
{
    public class LinkedListTests
    {
        [Fact]
        public void Insert_AddsItemsToLinkedList()
        {
            var linkedList = new LinkedList<int>();
            Assert.True(linkedList.IsEmpty);

            linkedList.Insert(1);
            Assert.False(linkedList.IsEmpty);
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(2, true)]
        [InlineData(3, false)]
        public void Find_GetsNodeWithCorrespondentValue(int value, bool found)
        {
            var linkedList = new LinkedList<int>();
            linkedList.Insert(1);
            linkedList.Insert(2);
            var nodeToFind = linkedList.Find(value);

            Assert.Equal(nodeToFind != null, found);
        }


        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void Delete_RemovesItemsFromLinkedList(int value)
        {
            var linkedList = new LinkedList<int>();
            linkedList.Insert(1);
            linkedList.Insert(2);

            var foundItem = linkedList.Find(value);
            Assert.NotNull(foundItem);

            linkedList.Delete(value);
            foundItem = linkedList.Find(value);
            Assert.Null(foundItem);
        }

        [Fact]
        public void Max_FindsMaximumValueInLinkedList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Insert(1);
            linkedList.Insert(2);

            Assert.Equal(2, linkedList.Max());
        }

        [Fact]
        public void Min_FindMinimumValueInLinkedList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Insert(1);
            linkedList.Insert(2);

            Assert.Equal(1, linkedList.Min());
        }
    }
}
