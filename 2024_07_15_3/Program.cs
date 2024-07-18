using System;

namespace _2024_07_15_3
{
    internal class Program
    {

        static int NumberSum (int maxNum)
        {
            int sum = 0;

            for (int i = 1; i < maxNum; i++)
            {
                if (i % 3 == 0  || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int maxNum;
            Console.Write("숫자 하나를 입력해 주세요: ");
            int.TryParse(Console.ReadLine(), out maxNum);
            Console.WriteLine(NumberSum(maxNum));
        }
    }
}
