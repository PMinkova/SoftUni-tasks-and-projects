namespace AVLTree
{
    using System;

    public class AVL<T> where T : IComparable<T>
    {
        public class Node
        {
            public Node(T value)
            {
                this.Value = value;
                this.Height = 1;
            }

            public T Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Height { get; set; }
        }

        public Node Root { get; private set; }

        public bool Contains(T element)
        {
            return this.Contains(this.Root, element) != null;
        }

        private Node Contains(Node node, T element)
        {
            if (node == null)
            {
                return null;
            }

            var compare = element.CompareTo(node.Value);

            if (compare < 0)
            {
                return this.Contains(node.Left, element);
            }

            if (compare > 0)
            {
                return this.Contains(node.Right, element);
            }

            return node;
        }

        public void Delete(T element)
        {
            if (this.Root == null)
            {
                return;
            }

            this.Root = this.Delete(this.Root, element);
        }

        private Node Delete(Node node, T element)
        {
            if (element.CompareTo(node.Value) < 0)
            {
                node.Left = this.Delete(node.Left, element);
            }
            else if (element.CompareTo(node.Value) > 0)
            {
                node.Right = this.Delete(node.Right, element);
            }
            else
            {
                if (node.Left == null && node.Right == null)
                {
                    return null;    
                }
                else if (node.Left == null)
                {
                    node = node.Right;
                }
                else if(node.Right == null)
                {
                    node = node.Left;
                }
                else
                {
                    Node temp = this.FindSmallestElement(node.Right);
                    node.Value = temp.Value;

                    node.Right = this.Delete(node.Right, temp.Value);
                }
            }

            node = this.Balance(node);
            node.Height = this.GetHeight(node);

            return node;
        }

        private Node FindSmallestElement(Node node)
        {
            if (node.Left == null)
            {
                return node;
            }

            return this.FindSmallestElement(node.Left); 
        }

        public void DeleteMin()
        {
            if (this.Root == null)
            {
                return;
            }

            var temp = this.FindSmallestElement(this.Root);
            this.Root = this.Delete(this.Root, temp.Value);
        }

        public void Insert(T element)
        {
            this.Root = this.Insert(this.Root, element);
        }

        private Node Insert(Node node, T element)
        {
            if (node == null)
            {
                return new Node(element);
            }

            if (element.CompareTo(node.Value) < 0)
            {
                node.Left = this.Insert(node.Left, element);
            }
            else
            {
                node.Right = this.Insert(node.Right, element);
            }

            node = this.Balance(node);
            node.Height = GetHeight(node);

            return node;
        }

        private Node Balance(Node node)
        {
            var balanceFactor = this.Height(node.Left) - this.Height(node.Right);

            if (balanceFactor > 1)
            {
                var childBalance = this.Height(node.Left.Left) - this.Height(node.Left.Right);

                if (childBalance < 0)
                {
                    node.Left = this.RotateLeft(node.Left);
                }

                node = this.RotateRight(node);
            }
            else if (balanceFactor < -1)
            {
                var childBalance = this.Height(node.Right.Left) - this.Height(node.Right.Right);

                if (childBalance > 0)
                {
                    node.Right = this.RotateRight(node.Right);
                }

                node = this.RotateLeft(node);
            }

            return node;
        }

        private Node RotateRight(Node node)
        {
            var left = node.Left;
            node.Left = left.Right;
            left.Right = node;

            node.Height = this.GetHeight(node);

            return left;
        }

        private Node RotateLeft(Node node)
        {
            var right = node.Right;
            node.Right = right.Left;
            right.Left = node;

            node.Height = this.GetHeight(node);

            return right;
        }

        public void EachInOrder(Action<T> action)
        {
            this.EachInOrder(this.Root, action);
        }

        private void EachInOrder(Node node, Action<T> action)
        {
            if (node == null)
            {
                return;
            }

            this.EachInOrder(node.Left, action);
            action(node.Value);
            this.EachInOrder(node.Right, action);
        }

        private int GetHeight(Node node)
        {
            return Math.Max(this.Height(node.Left), this.Height(node.Right)) + 1;
        }

        private int Height(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            return node.Height;
        }
    }
}
