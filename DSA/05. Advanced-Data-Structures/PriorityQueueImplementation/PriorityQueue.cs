namespace PriorityQueueImplementation
{
    using System;

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private BinaryHeap<T> heap;

        public PriorityQueue()
        {
            heap = new BinaryHeap<T>();
        }

        public int Count
        {
            get { return heap.Size; }
        }

        public void Enqueue(T item)
        {
            this.heap.Insert(item);
        }

        public T Dequeue()
        {
            T item = this.heap.Pop();
            return item;
        }
    }
}
