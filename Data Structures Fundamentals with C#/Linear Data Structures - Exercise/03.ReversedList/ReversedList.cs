namespace Problem03.ReversedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class ReversedList<T> : IAbstractList<T>
    {
        private const int DefaultCapacity = 4;

        private T[] items;

        public ReversedList()
            : this(DefaultCapacity) { }

        public ReversedList(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException(nameof(capacity));

            this.items = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                this.ValidateIndex(index);
                return this.items[this.Count - 1 - index];
            }
            set
            {
                this.ValidateIndex(index);
                this.items[index] = value;
            }
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || this.Count <= index)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public int Count { get; private set; }

        public void Add(T item)
        {
            GrowIfNeeded();

            this.items[this.Count] = item;
            this.Count++;
        }

        public bool Contains(T item)
        {
            return this.IndexOf(item) != -1;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (item.Equals(this.items[this.Count - i - 1]))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, T item)
        {
            ValidateIndex(index);

            GrowIfNeeded();

            this.Count++;

            var indexToInsertAt = this.Count - index - 1;
            var coppiedArray = new T[this.items.Length];

            Array.Copy(this.items, coppiedArray, indexToInsertAt);

            coppiedArray[indexToInsertAt] = item;

            for (int i = indexToInsertAt + 1; i < Count; i++)
            {
                coppiedArray[i] = this.items[i - 1];
            }

            this.items = coppiedArray;
        }

        public bool Remove(T item)
        {
            var index = this.IndexOf(item);

            if (index == -1)
            {
                return false;
            }

            this.RemoveAt(index);
            return true;
        }

        public void RemoveAt(int index)
        {
            this.ValidateIndex(index);

            var indexToRemove = this.Count - 1 - index;
            var coppiedArray = new T[this.items.Length];

            Array.Copy(this.items, coppiedArray, indexToRemove);

            for (int i = indexToRemove; i < this.Count - 1; i++)
            {
                coppiedArray[i] = this.items[i + 1];
            }

            this.items = coppiedArray;
            this.Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void GrowIfNeeded()
        {
            if (this.Count == this.items.Length)
            {
                this.items = Grow();
            }
        }

        private T[] Grow()
        {
            var doubledArray = new T[this.items.Length * 2];

            for (int i = 0; i < this.Count; i++)
            {
                doubledArray[i] = items[i];
            }

            return doubledArray;
        }

        private void EnsureNotEmpty()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }
        }
    }
}