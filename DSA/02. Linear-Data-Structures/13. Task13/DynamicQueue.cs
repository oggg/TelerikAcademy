namespace Task13
{
    using System;

    public class DynamicQueue<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int count;

        public DynamicQueue()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void Enqueue(T data)
        {
            var node = new Node<T>(data);

            if (head == null)
            {
                head = node;
                tail = head;
            }
            else
            {
                tail.Next = node;
                tail = tail.Next;
            }
            count++;
        }

        public object Dequeue()
        {
            if (head == null)
            {
                throw new ArgumentNullException();
            }
            var result = head.Data;
            head = head.Next;
            count--;
            return head.Data;
        }

        public void Clear()
        {
            this.head = null;
            this.tail = null;
            count = 0;
        }

        public int Count
        {
            get { return this.count; }
        }

        public T Peek()
        {
            return this.head.Data;
        }
    }
}
