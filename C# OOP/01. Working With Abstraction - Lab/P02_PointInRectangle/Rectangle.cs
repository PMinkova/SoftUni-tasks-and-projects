namespace P02_PointInRectangle
{
    public class Rectangle
    {
        public Rectangle(int top, int left, int bottom, int right)
        {
            this.TopLeftCoordinates = new Point(left, top);
            this.BottomRightCoordinates = new Point(right, bottom);
        }
        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.TopLeftCoordinates = topLeft;
            this.BottomRightCoordinates = bottomRight;
        }
        public Point TopLeftCoordinates { get; set; }

        public Point BottomRightCoordinates { get; set; }

        public bool Contains(Point point)
        {
            bool isInX = point.X >= TopLeftCoordinates.X &&
                         point.X <= BottomRightCoordinates.X;

            bool isInY = point.Y <= TopLeftCoordinates.Y &&
                         point.Y >= BottomRightCoordinates.Y;

            return isInX && isInY;
        }
    }
}
