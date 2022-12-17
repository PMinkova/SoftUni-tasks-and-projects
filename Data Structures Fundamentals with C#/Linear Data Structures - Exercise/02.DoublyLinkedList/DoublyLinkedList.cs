namespace Problem02.DoublyLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class DoublyLinkedList<T> : IAbstractLinkedList<T>
    {
        private class Node
        {
            public Node(T element)
            {
                this.Element = element;
            }

            public Node Next { get; set; }

            public Node Previous { get; set; }

            public T Element { get; set; }
        }

        private Node head;
        private Node tail;

        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            var element = new Node(item);

            if (this.Count == 0)
            {
                this.tail = element;
            }
            else
            {
                element.Next = this.head;
            }

            this.head = element;

            this.Count++;
        }

        public void AddLast(T item)
        {
            var element = new Node(item);

            if (this.Count == 0)
            {
                this.head = element;
            }
            else
            {
                element.Previous = this.tail;
                this.tail.Next = element;
            }

            this.tail = element;
            this.Count++;
        }

        public T GetFirst()
        {
            EnsureNotEmpty();

            return this.head.Element;
        }

        public T GetLast()
        {
            EnsureNotEmpty();

            return this.tail.Element;
        }

        public T RemoveFirst()
        {
            EnsureNotEmpty();

            var elementToRemove = this.head;

            if (this.Count == 1)
            {
                this.tail = null;
            }
            else
            {
                var nextElement = elementToRemove.Next;
                nextElement.Previous = null;
                this.head = nextElement;
            }

            this.Count--;

            return elementToRemove.Element;
        }

        public T RemoveLast()
        {
            EnsureNotEmpty();

            var lastNode = this.tail;

            if (this.Count == 1)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                var previousElement = lastNode.Previous;
                previousElement.Next = null;
                this.tail = previousElement;
            }

            this.Count--;

            return lastNode.Element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = this.head;

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
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }
        }
    }
}