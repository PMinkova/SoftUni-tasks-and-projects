using _01.Two_Three;

namespace Demo
{
    using System;

    class Program
    {
        static void Main()
        {
            var tree = new TwoThreeTree<string>();

            tree.Insert("50");
            tree.Insert("90");
            tree.Insert("25");
            tree.Insert("75");
            tree.Insert("150");
            tree.Insert("55");
            tree.Insert("80");
            tree.Insert("55");
            tree.Insert("95");
            tree.Insert("200");

            Console.WriteLine();
        }
    }
}
