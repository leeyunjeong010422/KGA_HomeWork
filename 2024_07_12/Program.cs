using System;

namespace _2024_07_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 과제1
            //Console.Write("1번 요소를 입력하여 주세요: ");
            //string input1 = Console.ReadLine();
            //int num1;
            //int.TryParse(input1, out num1);
            //Console.WriteLine();


            //Console.Write("2번 요소를 입력하여 주세요: ");
            //string input2 = Console.ReadLine();
            //int num2;
            //int.TryParse(input2, out num2);
            //Console.WriteLine();


            //Console.Write("3번 요소를 입력하여 주세요: ");
            //string input3 = Console.ReadLine();
            //int num3;
            //int.TryParse(input3, out num3);
            //Console.WriteLine();


            //Console.Write("4번 요소를 입력하여 주세요: ");
            //string input4 = Console.ReadLine();
            //int num4;
            //int.TryParse(input4, out num4);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("기본 실습 과제 1. 고정 배열 생성 및 출력");
            Console.ResetColor();
            int[] num = new int[4];
            int i = 0;
            for (i = 0; i < num.Length; i++)
            {
                Console.Write($"{i + 1}번 요소를 입력하여 주세요: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    num[i] = number;
                }
            }
            Console.WriteLine();
            Console.WriteLine("입력된 요소는 다음과 같습니다");
            foreach (int numCheck in num)
            {
                Console.Write($"{numCheck} ");
            }
            Console.WriteLine();
            #endregion

            #region 과제2


            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("기본 실습 과제 2. 배열의 요소 변경 및 출력");
            Console.ResetColor ();
            Console.WriteLine();

            int[,] array2 = new int[4, 4];
            int num_3 = 3;
            for (int j = 0; j < array2.GetLength(0); j++)
            {
                for (int k = 0; k < array2.GetLength(1); k++)
                {
                    array2[j, k] = num_3;
                    num_3 += 3;
                }
            }
            int change = array2[2, 3];
            array2[2, 3] = array2[3, 2];
            array2[3, 2] = change;
            for (int j = 0; j < array2.GetLength(0); j++)
            {
                for (int k = 0; k < array2.GetLength(1); k++)
                {
                    Console.Write(array2[j, k] + "\t");
                }
                Console.WriteLine();
            }

            //foreach (int numCheck in array2)
            //{
            //    Console.WriteLine(numCheck);
            //}

            #endregion
        }
    }
}
