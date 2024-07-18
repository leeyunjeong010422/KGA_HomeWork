using System;

namespace _2024_07_15
{
    internal class Program
    {  
        static int NumberMax(int a, int b, int c, int d)
        {        

            int[] arrMax = { a, b, c, d };
            int maxValue = a;

            for(int i = 0; i < arrMax.Length; i++)
            {
                if (maxValue < arrMax[i])
                {
                    maxValue = arrMax[i];
                }
            }
            return maxValue;

        }

        static void Main(string[] args)
        {

            int a, b, c, d;
            Console.Write("첫번째 값을 입력해주세요: ");
            int.TryParse(Console.ReadLine(), out a);

            Console.Write("두번째 값을 입력해주세요: ");
            int.TryParse(Console.ReadLine(), out b);

            Console.Write("세번째 값을 입력해주세요: ");
            int.TryParse(Console.ReadLine(), out c);

            Console.Write("네번째 값을 입력해주세요: ");
            int.TryParse(Console.ReadLine(), out d);

            Console.WriteLine(NumberMax(a, b, c, d));


        }
    }
}
