using System;

namespace _2024_07_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 과제1
            //과제 1.입력받은 횟수만큼 반복하는 기능 제작
            //사용자로부터 정수를 하나 입력받고, 그 수만큼 반복하는 문구 출력하기
            //"몇회 반복하시겠습니까?" 출력
            //입력을 받기
            //"n 회 반복중입니다"을 반복적으로 출력.n에는 현재 반복회차 표시하기

            Console.Write("몇 회 반복하시겠습니까?: ");
            string input1 = Console.ReadLine();
            int num1;
            int.TryParse(input1, out num1);

            if (num1 > 0)
            {
                for (int i = 1; i <= num1; i++)
                {
                    Console.WriteLine($"{i}회 반복중입니다.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine();

            #endregion

            #region 과제2
            //과제 2.다수의 입력을 받아 횟수만큼 반복하는 기능 제작
            //사용자로부터 정수 두 개를 입력 받고 입력한 값을 포함, 그 사이에 있는 모든 정수의 합을 구하는 프로그램.
            //예를 들어 유저가 4와 7을 입력하였다면 4 + 5 + 6 + 7의 결과값인 22를 출력해야 한다
            //"두 수 사이의 합을 구합니다. 시작할 작은 수를 입력하여주세요" 출력
            //시작할 수 입력 받기
            //"끝 수를 입력해주세요" 출력
            //마지막 수 입력 받기
            //반복문을 통하여 시작부터 끝 수까지 합을 임의의 변수에 저장
            //반복문이 끝난 후 "n1과 n2 사이 숫자의 합은 n3입니다" 출력

            Console.Write("두 수 사이의 합을 구합니다. 시작할 작은 수를 입력하여주세요: ");
            string input_1 = Console.ReadLine();
            int num_1;
            int.TryParse(input_1, out num_1);

            Console.Write("끝 수를 입력해주세요: ");
            string input_2 = Console.ReadLine();
            int num_2;
            int.TryParse(input_2, out num_2);

            int sum = 0;

            for (int i = num_1; i <= num_2; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"{num_1}과 {num_2} 사이의 숫자의 합은 {sum}입니다.");

            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine();

            #endregion

            #region 과제3
            //과제 3.구구단 기능 제작
            //유저로부터 정수 하나를 입력받고, 입력받은 수의 구구단을 출력하는 프로그램 제작.
            //예를 들어 3을 입력 받으면 3단에 대한 구구단 출력.
            //단, 유저가 입력한 수가 9를 초과하거나 숫자가 아닌 것을 입력하면 정상적인 입력이 아닐 경우,
            //제대로 된 입력이 나올때까지 무한 반복하는 예외처리도 있어야 한다
            //"출력하고자 하는 구구단을 입력해주시길 바랍니다" 출력
            //유저로부터 1~9까지의 숫자를 입력받음
            //"3x1 = 3, 3x2 =6, 3x3 = 9" 등등 해당 구구단 출력
            //만약 1~9가 아닌 숫자 혹은 문자열이 들어오면 다시 입력하라고 반복시키기

            while (true)
            {

                Console.Write("출력하고자 하는 구구단을 입력해주시길 바랍니다.: ");
                string input2 = Console.ReadLine();
                int num2;
                int.TryParse(input2, out num2);

                if (num2 >= 1 && num2 <= 9)
                {
                    for (int i = num2; i <= num2; i++)
                    {
                        for (int j = 2; j <= 9; j++)
                        {
                            Console.WriteLine($"{i} X {j} = {i * j}");
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("다시 입력해주세요.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine();

            #endregion

            #region 과제4
            //과제 4.별찍기 기능 구현
            //중첩반복문을 활용하여 아래 그림처럼 출력하는 네가지 프로그램을 각각 작성하여 보자.
            //Tip: Console.Write(" "); 를 쓰면 빈 공백 하나를,
            //Console.Write("*"); 을 쓰면 별 하나를 출력할 수 있다

            //1번
            int starCount = 5;

            for (int i = 1; i <= starCount; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine();

            //2번
            for (int i = 1; i <= starCount; i++)
            {
                for (int j = 1; j <= starCount - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine();

            //3번
            for (int i = starCount; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine();

            //4번
            for (int i = starCount; i >= 0; i--)
            {
                for (int j = 1; j <= starCount - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                #endregion


            }
        }
    }
}
