namespace Task12
{
    using System;

    public class DynamicStack<T> where T : struct
    {
        private T?[] array;
        private int topPosition;
        private int top;

        public DynamicStack()
        {
            this.array = new T?[2];
            this.TopPosition = 0;
        }

        public int Count
        {
            get { return this.array.Length; }
        }

        public T? Peek()
        {
            return this.array[this.TopPosition - 1];
        }

        public int TopPosition
        {
            get { return this.topPosition; }
            private set { this.topPosition = value; }
        }

        public T? Top
        {
            get
            {
                if (this.TopPosition == 0)
                {
                    return this.array[this.TopPosition];
                }
                else
                {
                    return this.array[this.TopPosition - 1];
                }
            }
            private set
            {
                this.array[this.top] = value;
            }
        }

        public T? Pop()
        {
            var last = this.array[this.TopPosition - 1];
            this.TopPosition--;
            this.array[this.TopPosition] = default(T);
            return last;
        }
        public bool Contains(T item)
        {
            if (Array.IndexOf(this.array, item) > -1)
            {
                return true;
            }

            return false;
        }

        public void Push(T item)
        {
            if (this.TopPosition >= this.Count)
            {
                Array.Resize(ref this.array, this.Count * 2);
            }

            this.array[this.TopPosition] = item;
            this.TopPosition++;
        }

        public void Clear()
        {
            this.array = new T?[10];
            this.TopPosition = 0;
        }
    }
}
