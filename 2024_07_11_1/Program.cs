﻿using System;

namespace _2024_07_11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //심화 과제 1.조건에 따른 무한 반복 기능
            //수업 내용 마지막에 있던 마을, 사냥터를 이동하는 프로그램은 문자열은 잘 걸러주고 재입력을 요구하지만
            //1, 2, 3이 아닌 숫자가 입력되면 재입력을 요구하는 것이 아닌 입력이 틀렸다며 바로 종료되는 문제가 있다.
            //숫자 1, 2, 3을 제외한 모든 입력에 대하여 재입력을 요구하도록 수정한다

            while (true)
            {

                Console.WriteLine("1. 마을 | 2. 사냥터 | 3. 상점");
                Console.Write("이동 할 장소를 설정해주세요: ");
                string input = Console.ReadLine();
                int move;
                int.TryParse(input, out move);

                if (move == 1 || move == 2 || move == 3)
                {
                    switch (move)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("마을로 이동하였습니다");
                            Console.ResetColor();
                            break;

                        case 2:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("사냥터로 이동하였습니다.");
                            Console.ResetColor();
                            break;

                        case 3:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("상점으로 이동하였습니다.");
                            Console.ResetColor();
                            break;
                    }
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("다시 입력해주세요");
                    Console.ResetColor();
                }
            }
        }
    }
}
