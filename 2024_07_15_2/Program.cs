using System;

namespace _2024_07_15_2
{
    internal class Program
    {

        static bool NumCompare (int a, int b)
        {
            bool NumCompareOk;

            if (a - b < 100)
                NumCompareOk = true;
            else
                NumCompareOk = false;

            return NumCompareOk;
        }
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("첫번째 수를 입력해주세요: ");
            int.TryParse(Console.ReadLine(), out a );

            Console.Write("두번째 수를 입력해주세요: ");
            int.TryParse(Console.ReadLine(), out b );

            Console.WriteLine(NumCompare(a, b));

        }
    }
}
