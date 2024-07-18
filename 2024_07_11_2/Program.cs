using System;

namespace _2024_07_11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //심화 과제 2.입력을 통한 다이아몬드 출력 기능 구현
            //출력할 다이아몬드 형태를 사용자로부터 입력 받은 후,
            //만약 짝수일경우 홀수를 다시 입력하라고 유저에게 무한 반복으로 요구한다.
            //홀수가 입력되었을 경우, 다이아몬드 중간 부분이 유저의 입력과 같은 다이아몬드를 출력하는 프로그램 제작.

            while (true)
            {
                Console.Write("출력할 다이아몬드를 홀수로 입력: ");
                string input = Console.ReadLine();
                int num;
                int.TryParse(input, out num);

                if (num == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("1이 아닌 값을 입력하세요");
                    Console.ResetColor();
                }
                else if (num % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("홀수를 입력하세요");
                    Console.ResetColor();
                }
                else
                {

                    for (int i = 1; i <= num; i += 2)
                    {
                        for (int j = 0; j < (num - i) / 2; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }

                    for (int i = num - 2; i >= 1; i -= 2)
                    {
                        for (int j = 0; j < (num - i) / 2; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                    break;
                }

            }
        }
    }
}
