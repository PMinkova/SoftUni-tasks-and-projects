using System;

namespace P02_PointInRectangle
{
    public class StartUp
    {
        public static void Main()
        {
            var rectangle = new Rectangle(3, 1, 1, 3);
            Console.WriteLine(rectangle.Contains(new Point(3, 3)));
        }
    }
}
