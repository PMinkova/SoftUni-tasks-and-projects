namespace Tree
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main(string[] args)
        {

            var tree = new Tree<int>(1,
                new Tree<int>(2,
                    new Tree<int>(4),
                                  new Tree<int>(5),
                                  new Tree<int>(6)),
                              new Tree<int>(3,
                                  new Tree<int>(7)));

            tree.RemoveNode(1);
        }
    }
}
