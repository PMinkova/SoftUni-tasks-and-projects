using System;
using System.Collections;
using System.Collections.Generic;

namespace P02_Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private int currentIndex;
        public ListyIterator(List<T> list)
        {
            this.List = list;
        }

        public List<T> List { get; set; }

        public bool Move()
        {
            if (currentIndex + 1 < this.List.Count)
            {
                currentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (currentIndex + 1 < this.List.Count)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (this.List.Count != 0)
            {
                Console.WriteLine(this.List[this.currentIndex]);
            }
            else
            {
                throw new ArgumentException("Invalid Operation!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T element in List)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}