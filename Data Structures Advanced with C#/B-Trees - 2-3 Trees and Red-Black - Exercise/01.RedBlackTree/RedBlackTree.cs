namespace _01.RedBlackTree
{
    using System;
    using System.Runtime.CompilerServices;

    public class RedBlackTree<T> where T : IComparable
    {
        private const bool Red = true;
        private const bool Black = false;

        public class Node
        {
            public Node(T value)
            {
                this.Value = value;
                this.Color = Red;
            }

            public T Value { get; set; }

            public Node Left { get; set; }

            public Node Right { get; set; }

            public bool Color { get; set; }
        }

        public Node root;

        private RedBlackTree(Node node)
        {
            this.PreOrderCopy(node);
        }

        private void PreOrderCopy(Node node)
        {
            if (node == null)
            {
                return;
            }

            this.Insert(node.Value);
            this.PreOrderCopy(node.Left);
            this.PreOrderCopy(node.Right);
        }

        public RedBlackTree()
        {

        }

        public void EachInOrder(Action<T> action)
        {
            this.EachInOrder(this.root, action);
        }

        public RedBlackTree<T> Search(T element)
        {
            var currentNode = this.FindNode(element);

            return new RedBlackTree<T>(currentNode);
        }

        private Node FindNode(T element)
        {
            var currentNode = this.root;

            while (currentNode != null)
            {
                if (IsLesser(element, currentNode.Value))
                {
                    currentNode = currentNode.Left;
                }
                else if (IsLesser(currentNode.Value, element))
                {
                    currentNode = currentNode.Right;
                }
                else
                {
                    break;
                }
            }

            return currentNode;
        }

        public void Insert(T value)
        {
            this.root = this.Insert(this.root, value);
            this.root.Color = Black;
        }

        public Node Insert(Node node, T element)
        {
            if (node == null)
            {
                return new Node(element);
            }

            if (IsLesser(element, node.Value))
            {
                node.Left = this.Insert(node.Left, element);
            }
            else 
            {                            
                node.Right = this.Insert(node.Right, element);
            }

            if (this.IsRed(node.Right))
            {
                node = this.RotateLeft(node);
            }

            if (this.IsRed(node.Left) && this.IsRed(node.Left.Left))
            {
                node = this.RotateRight(node);
            }

            if (this.IsRed(node.Left) && this.IsRed(node.Right))
            {
                this.FlipColors(node);
            }

            return node;
        }

        public void Delete(T key)
        {
            if (this.root == null)
            {
                throw new InvalidOperationException();
            }
        }

        public void DeleteMin()
        {
            if (this.root == null)
            {
                throw new InvalidOperationException();
            }

            var node = this.DeleteMin(this.root);
        }

        private Node DeleteMin(Node node)
        {
            if (node.Left == null)
            {
                return null;
            }

            if (!IsRed(node.Left) && !IsRed(node.Right))
            {
                node = this.MoveRedLeft(node.Left);
            }

            node.Left = this.DeleteMin(node.Left);

            return this.FixUp()
        }

        private Node MoveRedLeft(Node node)
        {
            this.FlipColors(node);

            if (this.IsRed(node.Right.Left))
            {
                node.Right = this.RotateRight(node.Right);
                node = this.RotateLeft(node);
                FlipColors(node);
            }

            return node;
        }

        private Node FixUp(Node node)
        {
            throw new NotImplementedException();
        }

        public void DeleteMax()
        {
            if (this.root == null)
            {
                throw new InvalidOperationException();
            }
        }

        public int Count()
        {
            return this.Count(this.root);
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

        private int Count(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + this.Count(node.Left) + this.Count(node.Right);
        }

        // Rotations
        private Node RotateRight(Node node)
        {
            var temp = node.Left;
            node.Left = temp.Right;
            temp.Right = node;
            temp.Color = temp.Right.Color;
            temp.Right.Color = Red;

            return temp;
        }

        private Node RotateLeft(Node node)
        {
            var temp = node.Right;
            node.Right = temp.Left;
            temp.Left = node;
            temp.Color = node.Color;
            temp.Left.Color = Red;

            return temp; 
        }

        private void FlipColors(Node node)
        {
            node.Color = !node.Color;
            node.Right.Color = !node.Right.Color;
            node.Left.Color = !node.Left.Color;
        }

        private bool IsRed(Node node)
        {
            if (node == null)
            {
                return false;
            }

            return node.Color == Red;
        }

        // Helper Methods
        private bool IsLesser(T a, T b)
        {
            return a.CompareTo(b) < 0;
        }

        private bool AreEqual(T a, T b)
        {
            return a.CompareTo(b) == 0;
        }
    }
}