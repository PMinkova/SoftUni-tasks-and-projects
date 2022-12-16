namespace Problem01.List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class List<T> : IAbstractList<T>
    {
        private const int DEFAULT_CAPACITY = 4;
        private T[] items;

        public List()
            : this(DEFAULT_CAPACITY)
        {

        }

        public List(int capacity)
        {
            this.items = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                ValidateIndex(index);
                return this.items[index];
            }
            set
            {
                ValidateIndex(index);
                this.items[index] = value;
            } 
        }
        public int Count { get; private set; }

        public void Add(T item)
        {
            GrowIfNecessary();

            this.items[this.Count] = item;
            this.Count++;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (item.Equals(items[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, T item)
        {
            ValidateIndex(index);
            GrowIfNecessary();

            for (int i = this.Count; i > index; i--)
            {
                this.items[i] = this.items[i - 1];
            }

            this.items[index] = item;
            this.Count++;
        }

        public bool Remove(T item)
        {
            if (!this.items.Contains(item))
            {
                return false;
            }

            var index = this.IndexOf(item);
            RemoveAt(index);
            return true;
        }

        public void RemoveAt(int index)
        {
            ValidateIndex(index);

            for (int i = index; i < this.Count - 1; i++)
            {
                items[i] = items[i + 1];
            }

            this.Count--;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || this.Count <= index)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
        }

        private T[] Grow()
        {
            var itemsCopyLength = this.items.Length * 2;
            var itemsCopy = new T[itemsCopyLength];

            Array.Copy(this.items, itemsCopy, this.Count);

            return itemsCopy;
        }

        private void GrowIfNecessary()
        {
            if (this.Count == this.items.Length)
            {
                this.items = Grow();
            }
        }
    }
}