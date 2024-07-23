namespace _2024_07_22_HomeWork2
{
    internal class Program
    {
        class MyCalculator
        {
            public static double Add(double x, double y)
            {
                return x + y;
            }

            public static double Subtract(double x, double y)
            {
                return x - y;
            }

            public static double Multiply(double x, double y)
            {
                return x * y;
            }

            public static double Divide(double x, double y)
            {
                if (y == 0)
                {
                    Console.WriteLine("0으로는 나눌 수 없습니다.");
                }
                return x / y;
            }

            public static double Squared(double x, double y)
            {
                return Math.Pow(x, y);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MyCalculator.Add(10.5, 2.5));
            Console.WriteLine(MyCalculator.Subtract(10.5, 2.5));
            Console.WriteLine(MyCalculator.Multiply(10.5, 2.5));
            Console.WriteLine(MyCalculator.Divide(10.5, 2.5));
            Console.WriteLine(MyCalculator.Divide(10.5, 0));
            Console.WriteLine(MyCalculator.Squared(10.5, 2.5));
        }
    }
}
