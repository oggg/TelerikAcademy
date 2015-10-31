namespace Taks11
{
    using System;
    using System.Collections.Generic;

    public class LinkedList<T>
    {

        public class ListItem
        {
            private ListItem next;
            private T value;

            public ListItem(T value)
            {
                this.Value = value;
                this.NextItem = null;
            }

            public T Value
            {
                get { return this.value; }
                set { this.value = value; }
            }

            public ListItem NextItem
            {
                get { return next; }
                set { next = value; }
            }

            public override string ToString()
            {
                try
                {
                    string.Format("Current: {0}, Next: {1}", this.Value, this.NextItem.Value);
                }
                catch (NullReferenceException)
                {
                    return string.Format("Current: {0}, Next: null", this.Value);
                }

                return string.Format("Current: {0}, Next: {1}", this.Value, this.NextItem.Value);
            }
        }

        private int size;
        private ListItem firstElement;
        private ListItem currentElement;

        public LinkedList()
        {
            size = 0;
            FirstElement = null;
        }

        public ListItem FirstElement
        {
            get { return this.firstElement; }
            set { this.firstElement = value; }
        }

        public int Count
        {
            get { return this.size; }
        }

        public void Add(T value)
        {
            this.size++;

            var item = new ListItem(value)
            {
                Value = value
            };


            if (this.FirstElement == null)
            {
                this.FirstElement = item;
            }
            else
            {
                currentElement.NextItem = item;
            }

            currentElement = item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            ListItem current = FirstElement;

            while (current != null)
            {
                yield return current.Value;
                current = current.NextItem;
            }
        }

    }
}
