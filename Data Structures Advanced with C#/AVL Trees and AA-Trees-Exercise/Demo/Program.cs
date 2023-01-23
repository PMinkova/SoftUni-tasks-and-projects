using System;
using AVLTree;

namespace Demo
{
    class Program
    {
        static void Main()
        {
            var tree = new AVL<int>();

            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(10);
        }
    }
}
