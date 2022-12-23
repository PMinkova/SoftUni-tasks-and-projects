namespace Tree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Tree<T> : IAbstractTree<T>
    {
        private List<Tree<T>> children;
        public Tree(T key, params Tree<T>[] children)
        {
            this.Key = key;
            this.children = new List<Tree<T>>();

            foreach (var child in children)
            {
                this.AddChild(child);
                child.Parent = this;
            }
        }

        public T Key { get; private set; }

        public Tree<T> Parent { get; private set; }

        public IReadOnlyCollection<Tree<T>> Children
            => this.children.AsReadOnly();

        public void AddChild(Tree<T> child)
        {
            this.children.Add(child);
        }

        public void AddParent(Tree<T> parent)
        {
            this.Parent = parent;
        }

        public string AsString()
        {
            var sb = new StringBuilder();

            OrderDfs(sb, this, 0);

            return sb.ToString().Trim();
        }

        private void OrderDfs(StringBuilder sb, Tree<T> tree, int intend)
        {
            sb
                .Append(' ', intend)
                .AppendLine(tree.Key.ToString());

            foreach (var child in tree.Children)
            {
                OrderDfs(sb, child, intend + 2);
            }
        }

        public IEnumerable<T> GetInternalKeys()
        {
            return BfsWithResultKeys(tree => tree.Children.Any() && tree.Parent != null)
                .Select(tree => tree.Key);
        }

        public IEnumerable<T> GetLeafKeys()
        {
            return BfsWithResultKeys(tree => !tree.Children.Any())
                .Select(tree => tree.Key);
        }

        public T GetDeepestKey()
        {
            return GetDeepestNode().Key;
        }

        public IEnumerable<T> GetLongestPath()
        {
            var result = new Stack<T>();
            var node = GetDeepestNode();

            result.Push(node.Key);

            while (node.Parent != null)
            {
                node = node.Parent;
                result.Push(node.Key);
            }

            return result;
        }

        protected IEnumerable<Tree<T>> BfsWithResultKeys(Predicate<Tree<T>> predicate)
        {
            var queue = new Queue<Tree<T>>();
            var result = new List<Tree<T>>();

            queue.Enqueue(this);

            while (queue.Any())
            {
                var subtree = queue.Dequeue();

                if (predicate.Invoke(subtree))
                {
                    result.Add(subtree);
                }

                foreach (var child in subtree.Children)
                {
                    queue.Enqueue(child);
                }
            }

            return result;
        }

        private Tree<T> GetDeepestNode()
        {
            var leafs = BfsWithResultKeys(tree => !tree.Children.Any());

            Tree<T> deepestNode = null;
            var maxDepth = 0;

            foreach (var leaf in leafs)
            {
                var depth = this.GetDepth(leaf);

                if (depth > maxDepth)
                {
                    maxDepth = depth;
                    deepestNode = leaf;
                }
            }

            return deepestNode;
        }

        private int GetDepth(Tree<T> leaf)
        {
            var detpth = 0;

            while (leaf.Parent != null)
            {
                detpth++;
                leaf = leaf.Parent;
            }

            return detpth;
        }
    }
}
