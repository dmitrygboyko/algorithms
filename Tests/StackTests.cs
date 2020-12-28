using Xunit;
using Algorithms.DataStructures;

namespace Tests
{
    public class StackTests
    {
        [Fact]
        public void Push_AddsNewItemToStack()
        {
            var stack = new Stack();

            // Pre-condition
            Assert.True(stack.IsEmpty);

            stack.Push(1);
            Assert.False(stack.IsEmpty);
        }

        [Fact]
        public void Pop_RemovesItemFromStack()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);

            // Pre-condition
            Assert.False(stack.IsEmpty);

            var popedItem = stack.Pop();
            Assert.Equal(2, popedItem);
            popedItem = stack.Pop();
            Assert.Equal(1, popedItem);
            Assert.True(stack.IsEmpty);
        }

        [Fact]
        public void StackworksCorrectly_When_Resized()
        {
            var stack = new Stack(1, 4);
            stack.Push(1);
            stack.Push(2);

            var popedItem = stack.Pop();
            Assert.Equal(2, popedItem);

            popedItem = stack.Pop();
            Assert.Equal(1, popedItem);

            Assert.True(stack.IsEmpty);
        }
    }
}
