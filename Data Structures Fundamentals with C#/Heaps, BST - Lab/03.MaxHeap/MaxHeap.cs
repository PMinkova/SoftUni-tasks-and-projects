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
            this.elements.Add(element);
            this.HeapifyUp(this.elements.Count - 1);
        }

        public T ExtractMax()
        {
            if (!this.elements.Any())
            {
                throw new InvalidOperationException();
            }

            var biggestElement = this.elements[0];
            this.Swap(0, this.elements.Count - 1);
            this.elements.RemoveAt(this.elements.Count - 1);
            this.HeapifyDown(0);

            return biggestElement;
        }

        private void HeapifyDown(int index)
        {
            var greaterIndex = GetBiggerChildIndex(index);

            while (IsIndexvalid(greaterIndex) && this.IsGreater(greaterIndex, index))
            {
                this.Swap(index, greaterIndex);
                index = greaterIndex;
                greaterIndex = GetBiggerChildIndex(index);
            }
        }

        private int GetBiggerChildIndex(int index)
        {
            var firstChildIndex = index * 2 + 1;
            var secondChildIndex = index * 2 + 2;

            if (IsIndexvalid(firstChildIndex) && IsIndexvalid(secondChildIndex))
            {
                if (this.elements[firstChildIndex].CompareTo(this.elements[secondChildIndex]) < 0)
                {
                    return secondChildIndex;
                }

                return firstChildIndex;
            }
            else if (!IsIndexvalid(firstChildIndex) && !IsIndexvalid(secondChildIndex))
            {
                return -1;
            }
            else if (!IsIndexvalid(secondChildIndex))
            {
                return firstChildIndex;
            }

            return secondChildIndex;
        }

        private bool IsIndexvalid(int index)
        {
            return 0 <= index && index < this.elements.Count;
        }

        public T Peek()
        {
            if (!this.elements.Any())
            {
                throw new InvalidOperationException();
            }

            return this.elements[0];
        }

        private bool IsGreater(int firstIndex, int secondIndex)
        {
            return elements[firstIndex].CompareTo(elements[secondIndex]) > 0;
        }

        private int GetParentIndex(int index)
        {
            return (index - 1) / 2;
        }

        private void HeapifyUp(int index)
        {
            var parentIndex = this.GetParentIndex(index);

            while (index > 0 && IsGreater(index, parentIndex))
            {
                this.Swap(index, parentIndex);
                index = parentIndex;
                parentIndex = this.GetParentIndex(index);
            }
        }

        private void Swap(int index, int parentIndex)
        {
            var temp = elements[index];
            this.elements[index] = elements[parentIndex];
            this.elements[parentIndex] = temp;
        }
    }
}

