namespace Tree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Tree<T> : IAbstractTree<T>
    {
        private List<Tree<T>> children;
        private T value;
        private Tree<T> parent;

        public Tree(T value)
        {
            this.value = value;
            this.children = new List<Tree<T>>();
        }

        public Tree(T value, params Tree<T>[] children)
            : this(value)
        {
            foreach (var child in children)
            {
                child.parent = this;
                this.children.Add(child);
            }
        }

        public void AddChild(T parentKey, Tree<T> child)
        {
            var searchedNode = FindNodeWithBfs(parentKey);

            if (searchedNode == null)
            {
                throw new ArgumentNullException();
            }

            searchedNode.children.Add(child);
            child.parent = this;
        }

        private Tree<T> FindNodeWithBfs(T parentKey)
        {
            var queue = new Queue<Tree<T>>();

            queue.Enqueue(this);

            while (queue.Any())
            {
                var subtree = queue.Dequeue();

                if (subtree.value.Equals(parentKey))
                {
                    return subtree;
                }

                foreach (var child in subtree.children)
                {
                    queue.Enqueue(child);
                }
            }

            return null;
        }

        public IEnumerable<T> DfsWithRecursion()
        {
            var result = new List<T>();

            Dfs(this, result);

            return result;
        }

        private void Dfs(Tree<T> tree, List<T> result)
        {
            foreach (var child in tree.children)
            {
                Dfs(child, result);
            }

            result.Add(tree.value);
        }

        public IEnumerable<T> OrderBfs()
        {
            var queue = new Queue<Tree<T>>();
            var result = new List<T>();

            queue.Enqueue(this);

            while (queue.Any())
            {
                var subTree = queue.Dequeue();

                result.Add(subTree.value);

                foreach (var child in subTree.children)
                {
                    queue.Enqueue(child);
                }
            }

            return result;
        }

        public IEnumerable<T> OrderDfs()
        {
            var stack = new Stack<Tree<T>>();
            var result = new Stack<T>();

            stack.Push(this);

            while (stack.Any())
            {
                var node = stack.Pop();

                foreach (var child in node.children)
                {
                    stack.Push(child);
                }

                result.Push(node.value);
            }

            return result;
        }

        public void RemoveNode(T nodeKey)
        {
            var nodeToRemove = FindNodeWithBfs(nodeKey);

            if (nodeToRemove == null)
            {
                throw new ArgumentNullException();
            }

            var parentNode = nodeToRemove.parent;

            if (parentNode == null)
            {
                throw new ArgumentException();
            }

            parentNode.children.Remove(nodeToRemove);
            nodeToRemove.parent = null;
        }

        public void Swap(T firstKey, T secondKey)
        {
            var firsNode = FindNodeWithBfs(firstKey);
            var secondNode = FindNodeWithBfs(secondKey);

            if (firsNode == null || secondNode == null)
            {
                throw new ArgumentNullException();
            }

            var firstNodeParent = firsNode.parent;
            var secondNodeParent = secondNode.parent;

            if (firstNodeParent == null || secondNodeParent == null)
            {
                throw new ArgumentException();
            }

            var firstNodeIndex = firstNodeParent.children.FindIndex(x => x.Equals(firsNode));
            var secondNodeIndex = secondNodeParent.children.FindIndex(x => x.Equals(secondNode));

            firstNodeParent.children[firstNodeIndex] = secondNode;
            secondNodeParent.children[secondNodeIndex] = firsNode;

            secondNode.parent = firstNodeParent;
            firsNode.parent = secondNodeParent;
        }
    }
}
