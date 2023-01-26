namespace Hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;

    public class Hierarchy<T> : IHierarchy<T>
    {
        private class Node
        {
            public Node(T value)
            {
                this.Value = value;
                this.Children = new List<Node>();
            }
            public T Value { get; set; }

            public Node Parent { get; set; }

            public List<Node> Children { get; set; }
        }

        private Dictionary<T, Node> nodes;

        private Node root;

        public Hierarchy(T value)
        {
            this.root = new Node(value);
            this.nodes = new Dictionary<T, Node>();
            nodes.Add(value, root);
        }

        public int Count => this.nodes.Count;

        public void Add(T element, T child)
        {
            if (!this.Contains(element) || this.Contains(child))
            {
                throw new ArgumentException();
            }

            var newChild = new Node(child);
            newChild.Parent = this.nodes[element];
            this.nodes[element].Children.Add(newChild);
            this.nodes.Add(child, newChild);
        }

        public bool Contains(T element)
        {
            return this.nodes.ContainsKey(element);
        }

        public IEnumerable<T> GetChildren(T element)
        {
            if (!this.Contains(element))
            {
                throw new ArgumentException();
            }

            return this.nodes[element].Children.Select(n => n.Value);
        }

        public IEnumerable<T> GetCommonElements(Hierarchy<T> other)
        {
            var result = new List<T>();

            foreach (var element in this.nodes.Keys)
            {
                if (other.nodes.ContainsKey(element))
                {
                    result.Add(element);
                }
            }

            return result;
        }

        public T GetParent(T element)
        {
            if (!this.nodes.ContainsKey(element))
            {
                throw new ArgumentException();
            }

            if (this.nodes[element].Parent == null)
            {
                return default;
            }

            return this.nodes[element].Parent.Value;
        }

        public void Remove(T element)
        {
            if (!this.Contains(element))
            {
                throw new ArgumentException();
            }

            if (this.nodes[element].Equals(root))
            {
                throw new InvalidOperationException();
            }

            var node = this.nodes[element];
            var parent = node.Parent;
            var children = node.Children;

            foreach (var child in children)
            {
                parent.Children.Add(child);
                child.Parent = parent;
            }

            parent.Children.Remove(node);
            this.nodes.Remove(element);
        }
        public IEnumerator<T> GetEnumerator()
        {
            var queue = new Queue<Node>();

            queue.Enqueue(this.root);

            while (queue.Any())
            {
                var currentNode = queue.Dequeue();

                yield return currentNode.Value;

                foreach (var child in currentNode.Children)
                {
                    queue.Enqueue(child);
                }

            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    }
}