namespace Problem04.SinglyLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class SinglyLinkedList<T> : IAbstractLinkedList<T>
    {
        private class Node
        {
            public Node(T element, Node next)
            {
                this.Element = element;
                this.Next = next;
            }

            public Node(T element)
                : this(element, null)
            {

            }

            public T Element;

            public Node Next;
        }

        private Node head;

        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            var newHead = new Node(item, this.head);

            this.head = newHead;
            this.Count++;
        }

        public void AddLast(T item)
        {
            var newNode = new Node(item);

            if (this.Count == 0)
            {
                this.head = newNode;
            }
            else
            {
                var node = this.head;

                while (node.Next != null)
                {
                    node = node.Next;
                }

                node.Next = newNode;
            }

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

            var node = this.head;

            while (node.Next != null)
            {
                node = node.Next;
            }

            return node.Element;
        }

        public T RemoveFirst()
        {
            EnsureNotEmpty();

            var node = this.head;

            if (this.Count > 1)
            {
                this.head = node.Next;
            }

            this.Count--;
            return node.Element;
        }

        public T RemoveLast()
        {
            EnsureNotEmpty();

            var node = this.head;

            while (node.Next != null)
            {
                var previousNode = node;
                node = node.Next;

                if (node.Next == null)
                {
                    previousNode.Next = null;
                    break;
                }
            }

            this.Count--;
            return node.Element;
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