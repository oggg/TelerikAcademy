namespace PriorityQueueImplementation
{
    using System;
    using System.Collections.Generic;


    public class BinaryHeap<T>
    {
        private T[] data;

        private int size = 0;

        private Comparison<T> comparison;

        public BinaryHeap()
        {
            Constructor(4, null);
        }

        public BinaryHeap(Comparison<T> comparison)
        {
            Constructor(4, comparison);
        }

        public BinaryHeap(int capacity)
        {
            Constructor(capacity, null);
        }

        public BinaryHeap(int capacity, Comparison<T> comparison)
        {
            Constructor(capacity, comparison);
        }

        private void Constructor(int capacity, Comparison<T> comparison)
        {
            data = new T[capacity];
            this.comparison = comparison;
            if (this.comparison == null)
                this.comparison = new Comparison<T>(Comparer<T>.Default.Compare);
        }

        public int Size
        {
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Add an item to the heap
        /// </summary>
        /// <param name="item"></param>
        public void Insert(T item)
        {
            if (size == data.Length)
            {
                Resize();
            }

            data[size] = item;
            HeapifyUp(size);
            size++;
        }

        /// <summary>
        /// Get the item of the root
        /// </summary>
        /// <returns></returns>
        public T Peak()
        {
            return data[0];
        }

        /// <summary>
        /// Extract the item of the root
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            T item = data[0];
            size--;
            data[0] = data[size];
            HeapifyDown(0);
            return item;
        }

        private void Resize()
        {
            T[] resizedData = new T[data.Length * 2];
            Array.Copy(data, 0, resizedData, 0, data.Length);
            data = resizedData;
        }

        private void HeapifyUp(int childIdx)
        {
            if (childIdx > 0)
            {
                int parentIdx = (childIdx - 1) / 2;
                if (comparison.Invoke(data[childIdx], data[parentIdx]) < 0)
                {
                    // swap parent and child
                    T t = data[parentIdx];
                    data[parentIdx] = data[childIdx];
                    data[childIdx] = t;
                    HeapifyUp(parentIdx);
                }
            }
        }

        private void HeapifyDown(int parentIdx)
        {
            int leftChildIdx = 2 * parentIdx + 1;
            int rightChildIdx = leftChildIdx + 1;
            int largestChildIdx = parentIdx;
            if (leftChildIdx < size && comparison.Invoke(data[leftChildIdx], data[largestChildIdx]) < 0)
            {
                largestChildIdx = leftChildIdx;
            }
            if (rightChildIdx < size && comparison.Invoke(data[rightChildIdx], data[largestChildIdx]) < 0)
            {
                largestChildIdx = rightChildIdx;
            }
            if (largestChildIdx != parentIdx)
            {
                T t = data[parentIdx];
                data[parentIdx] = data[largestChildIdx];
                data[largestChildIdx] = t;
                HeapifyDown(largestChildIdx);
            }
        }
    }
}