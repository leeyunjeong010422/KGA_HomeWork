namespace _2024_07_25_7
{
    internal class Program
    {
        public struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public static Point operator +(Point a, Point b)
            {
                return new Point (a.x + b.x, a.y + b.y);
            }

            public static Point operator -(Point a, Point b)
            {
                return new Point (a.x - b.x, a.y - b.y);
            }
        }
        static void Main(string[] args)
        {
            Point point1 = new Point(1,2);
            Point point2 = new Point(2,3);

            // (1,2) + (2,3) == (3,5)
            Point sum = point1 + point2;

            Point minus = point1 - point2;

            Console.WriteLine($"{sum.x} {sum.y}");
            Console.WriteLine($"{minus.x} {minus.y}");

        }
    }
}
