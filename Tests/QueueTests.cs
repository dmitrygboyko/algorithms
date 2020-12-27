using Xunit;
using Algorithms.DataStructures;

namespace Tests
{
    public class QueueTests
    {
        [Fact]
        public void Enqueue_AddsNewItemToQueue()
        {
            var queue = new Queue();

            // Pre-condition
            Assert.True(queue.IsEmpty);

            queue.Enqueue(1);
            Assert.False(queue.IsEmpty);
        }

        [Fact]
        public void Dequeue_RemovesItemFromQueue()
        {
            var queue = new Queue();
            queue.Enqueue(1);

            // Pre-condition
            Assert.False(queue.IsEmpty);

            var dequeuedItem = queue.Dequeue();
            Assert.Equal(1, dequeuedItem);
            Assert.True(queue.IsEmpty);
        }

        [Fact]
        public void QueueQworksCorrectly_When_Resized()
        {
            var queue = new Queue(1, 4);
            queue.Enqueue(1);
            queue.Enqueue(2);

            var dequeuedItem = queue.Dequeue();
            Assert.Equal(1, dequeuedItem);

            dequeuedItem = queue.Dequeue();
            Assert.Equal(2, dequeuedItem);

            Assert.True(queue.IsEmpty);
        }
    }
}
