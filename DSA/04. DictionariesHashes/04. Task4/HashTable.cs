namespace Task4
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class HashTable<K, T> : IEnumerable<KeyValuePair<K, T>>
    {
        private LinkedList<KeyValuePair<K, T>>[] content;
        private int count;
        private int capacity;

        public HashTable()
        {
            this.Clear();
        }

        public LinkedList<KeyValuePair<K, T>>[] Content
        {
            get { return this.content; }
            set { this.content = value; }
        }

        public K[] Keys
        {
            get
            {
                var keyList = new List<K>(this.Count);
                foreach (var kvp in this)
                {
                    keyList.Add(kvp.Key);
                }
                return keyList.ToArray();
            }
        }

        public T this[K key]
        {
            get { return this.Find(key); }
        }

        public void Add(K key, T value)
        {
            if (this.Contains(key))
            {
                return;
            }

            var index = this.GetIndex(key);

            var kvp = new KeyValuePair<K, T>(key, value);
            this.Content.SetValue(kvp, this.count);
            this.count++;

            if ((double)(this.count / this.Content.Length) >= 0.75)
            {
                Array.Resize(ref this.content, this.Content.Length * 2);
            }
        }

        public void Remove(K key)
        {
            if (!this.Contains(key))
            {
                throw new ArgumentNullException();
            }

            var index = this.GetIndex(key);

            var toRemove = this.Content[index].First(item => item.Key.ToString() == key.ToString());
            this.Content[index].Remove(toRemove);
            --this.count;
        }

        public bool Contains(K key)
        {
            var index = this.GetIndex(key);
            if (this.Content[index] == null)
            {
                return false;
            }

            var chain = this.Content[index];

            foreach (var kvp in chain)
            {
                if (kvp.Key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

        public T Find(K key)
        {
            var index = this.GetIndex(key);

            if (this.Content[index] == null)
            {
                return default(T);
            }

            var chain = this.Content[index];
            foreach (var kvp in chain)
            {
                if (kvp.Key.Equals(key))
                {
                    return kvp.Value;
                }
            }

            return default(T);
        }

        public int Count
        {
            get { return this.count; }
        }

        public void Clear()
        {
            this.count = 0;
            this.capacity = 16;
            this.Content = new LinkedList<KeyValuePair<K, T>>[16];
        }

        private int GetIndex(K key)
        {
            var hash = key.GetHashCode();
            var index = hash % this.content.Length;
            return index;
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (var value in this.Content)
            {
                if (value == null)
                {
                    continue;
                }

                foreach (var item in value)
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
