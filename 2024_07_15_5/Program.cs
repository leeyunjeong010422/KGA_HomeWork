using System;

namespace _2024_07_15_5
{
    internal class Program
    {

        static int Fibonacci (int a)
        {

            int[] fiboArr = new int[a + 1];
            fiboArr[0] = 0;
            fiboArr[1] = 1;
            
            if (a <= 1)
            {
                return fiboArr[a];
            }
            else
            {
                for (int i = 2; i <= a; i++)
                {

                    fiboArr[i] = (fiboArr[i - 1] + fiboArr[i - 2]);
                }
            }
            return (fiboArr[a]);

        }

        static void Main(string[] args)
        {
            Console.Write("수를 하나 입력해주세요: ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine(Fibonacci(a));
        }
    }
}
