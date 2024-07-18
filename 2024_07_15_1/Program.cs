using System;

namespace _2024_07_15_1
{
    internal class Program
    {

        static float NumberSum(float a, float b, float c, float d, float e)
        {
            float[] arrSum = { a, b, c, d, e };

            int n = arrSum.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arrSum[j] > arrSum[j + 1])
                    {
                        float temp = arrSum[j];
                        arrSum[j] = arrSum[j + 1];
                        arrSum[j + 1] = temp;
                    }
                }
            }

            float maxNum1 = arrSum[n - 1];
            float maxNum2 = arrSum[n - 2];

            return maxNum1 + maxNum2;

        }


        static void Main(string[] args)
        {
            float a, b, c, d, e;

            Console.Write("첫번째 수를 입력해주세요: ");
            float.TryParse(Console.ReadLine(), out a);

            Console.Write("두번째 수를 입력해주세요: ");
            float.TryParse(Console.ReadLine(), out b);

            Console.Write("세번째 수를 입력해주세요: ");
            float.TryParse(Console.ReadLine(), out c);

            Console.Write("네번째 수를 입력해주세요: ");
            float.TryParse(Console.ReadLine(), out d);

            Console.Write("다섯번째 수를 입력해주세요: ");
            float.TryParse(Console.ReadLine(), out e);


            Console.WriteLine(NumberSum(a, b, c, d, e));

        }
    }
}
