using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> list;

        public Box()
        {
            list = new List<T>();
        }

        public int Count => this.list.Count;

        public void Add(T element)
        {
            this.list.Add(element);
        }

        public T Remove()
        {
            var element = this.list[this.list.Count - 1];
            this.list.RemoveAt(this.list.Count - 1);

            return element;
        }
    }
}
