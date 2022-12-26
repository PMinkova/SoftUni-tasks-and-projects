namespace _03.MaxHeap
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxHeap<T> : IAbstractHeap<T> where T : IComparable<T>
    {
        private List<T> elements;

        public MaxHeap()
        {
            this.elements = new List<T>();
        }

        public int Size => this.elements.Count;

        public void Add(T element)
        {
            
        }

        public T ExtractMax()
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            if (!this.elements.Any())
            {
                throw new InvalidOperationException();
            }

            return this.elements[0];
        }
    }
}
