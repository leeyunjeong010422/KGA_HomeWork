using System;

namespace _2024_07_15_4
{
    internal class Program
    {
        static int numSum(int num)
        {
            string numString = num.ToString();

            int[] numArr = new int[numString.Length];

            int sum = 0;
            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = numString[i] - '0';
                sum += numArr[i];

            }
            return (int)sum;
        }
        static void Main(string[] args)
        {
            int num;
            Console.Write("숫자를 입력해주세요: ");
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine(numSum(num));
        }
    }
}
