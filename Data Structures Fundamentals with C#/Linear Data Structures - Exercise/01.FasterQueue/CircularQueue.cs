namespace Problem01.CircularQueue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class CircularQueue<T> : IAbstractQueue<T>
    {
        private const int DEFAULT_CAPACITY = 4;
        private T[] elements;
        private int startIndex;
        private int endIndex;

        public CircularQueue()
            : this(DEFAULT_CAPACITY)
        {

        }

        public CircularQueue(int capacity)
        {
            this.elements = new T[capacity];
        }

        public int Count { get; private set; }

        public T Dequeue()
        {
            EnsureNotEmpy();

            var element = this.elements[startIndex];
            this.startIndex = (this.startIndex + 1) % this.elements.Length;
            this.Count--;
            return element;
        }

        public void Enqueue(T item)
        {
            if (this.Count == this.elements.Length)
            {
                Grow();
            }

            this.elements[endIndex] = item;
            this.endIndex = (endIndex + 1) % this.elements.Length;

            this.Count++;
        }

        private void Grow()
        {
            this.elements = this.CopyElements(new T[this.elements.Length * 2]);

            this.startIndex = 0;
            this.endIndex = this.Count;
        }

        private T[] CopyElements(T[] arrayCopy)
        {
            for (int i = 0; i < this.Count; i++)
            {
                var index = (this.startIndex + i) % this.elements.Length;
                arrayCopy[i] = this.elements[index];
            }

            return arrayCopy;
        }

        public T Peek()
        {
            EnsureNotEmpy();
            return this.elements[this.startIndex];
        }

        public T[] ToArray()
        {
            return this.CopyElements(new T[this.Count]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                var index = (this.startIndex + i) % this.elements.Length;
                yield return this.elements[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void EnsureNotEmpy() 
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }
        }
    }
}
