namespace Problem02.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IAbstractStack<T>
    {
        private class Node
        {
            public Node(T element, Node next)
            {
                this.Element = element;
                this.Next = next;
            }

            public T Element { get; set; }

            public Node Next { get; set; }
        }

        private Node top;

        public int Count { get; private set; }

        public void Push(T item)
        {
            var next = this.top;
            Node node = new Node(item, next);

            this.top = node;
            this.Count++;
        }

        public T Pop()
        {
            EnsureNotEmpty();

            var node = this.top.Element;
            this.top = this.top.Next;
            this.Count--;

            return node;
        }

        public T Peek()
        {
            EnsureNotEmpty();

            return this.top.Element;
        }

        public bool Contains(T item)
        {
            var node = this.top;

            while (node != null)
            {
                if (node.Element.Equals(item))
                {
                    return true;
                }

                node = node.Next;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = this.top;

            while (node != null)
            {
                yield return node.Element;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void EnsureNotEmpty()
        {
            if (this.top == null)
            {
                throw new InvalidOperationException();
            }
        }
    }
}