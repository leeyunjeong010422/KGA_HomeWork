﻿using System;

namespace _2024_07_10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //리듬게임에서 정확한 타이밍에 키를 누를 경우 성공으로 인정되는 프로그램이 있습니다.
            //완전 오입력을 할 경우, 성공 횟수에서 - 1이 되기에, 최종 성공 갯수가 음수가 될 수도 있습니다.
            //"성공한 갯수를 입력하여 주세요" 라고 먼저 출력 후 입력을 받음
            //성공 갯수에 따라서 SS, S, A, B, F 의 등급이 주어집니다.
            //100개를 모두 성공 시킬 경우, "SS 등급입니다" 출력
            //90개 이상일 경우, "S등급 입니다" 출력
            //70개 이상이면 "A등급입니다" 출력
            //40개 이상이면 "B등급입니다" 출력
            //그 외는 "F등급입니다"를 출력한다

            Console.Write("성공한 갯수를 입력하여 주세요: ");
            string input = Console.ReadLine();
            int score;
            int.TryParse(input, out score);

            if(score == 100)
            {
                Console.WriteLine("SS등급입니다.");
            }
            else if(score >= 90) {
                Console.WriteLine("S등급입니다.");
            }
            else if(score >= 70)
            {
                Console.WriteLine("A등급입니다.");
            }
            else if(score >= 40)
            {
                Console.WriteLine("B등급입니다.");
            }
            else
            {
                Console.WriteLine("F등급입니다");
            }
        }
    }
}
