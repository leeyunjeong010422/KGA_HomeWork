using System;

namespace HomeWork_0711
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int computerNum = 0;          

            while (true)
            {
                computerNum = random.Next(100, 999);

                int fNum1 = computerNum % 10; //1
                int sNum1 = computerNum / 10 % 10; //10
                int tNum1 = computerNum / 100 % 10; //100

                if (fNum1 != sNum1 && fNum1 != tNum1 && sNum1 != tNum1)
                {
                    break;
                }
            }


            Console.WriteLine($"컴퓨터가 선택한 숫자: {computerNum}");           

            int count = 1;
            int maxCount = 11;               

            while (count < maxCount)
            {

                int fNum1 = computerNum % 10;
                int sNum1 = computerNum / 10 % 10;
                int tNum1 = computerNum / 100 % 10;

                Console.WriteLine("=======================================");
                Console.WriteLine($"{count} 이닝");
                Console.WriteLine("=======================================");

                Console.Write("중복되지 않는 임의의 세자리 수를 입력해 주세요: ");
                string input = Console.ReadLine();
                int peopleNum;
                int.TryParse(input, out peopleNum);
                Console.WriteLine();

                if (peopleNum < 100 || peopleNum > 999)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("잘못된 숫자입니다. 세자리수로 입력해주세요");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    continue;
                }

                int fNum = peopleNum % 10; //1
                int sNum = peopleNum / 10 % 10; //10
                int tNum = peopleNum / 100 % 10; //100
                Console.WriteLine();

                if (fNum == sNum || fNum == tNum || sNum == tNum)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("중복되는 숫자입니다.");
                    Console.WriteLine("중복되지 않게 입력해주세요.");
                    Console.ResetColor();
                    Console.WriteLine();
                    continue;
                }

                int strike = 0;
                int ball = 0;

                if (fNum == fNum1) strike++;
                if (sNum == sNum1) strike++;
                if (tNum == tNum1) strike++;

                if (fNum != fNum1 && fNum == sNum1 || fNum == tNum1) ball++;
                if (sNum != sNum1 && sNum == fNum1 || sNum == tNum1) ball++;
                if (tNum != tNum1 && tNum == fNum1 || tNum == sNum1) ball++;

                if (strike == 0 && ball == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("아웃");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{strike}스트라이크 {ball}볼");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                count++;

                if (strike == 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("승리입니다.");
                    Console.ResetColor();
                    break;
                }
            }

            if (count == maxCount)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("컴퓨터의 승리입니다.");
                Console.WriteLine($"컴퓨터의 숫자는 {computerNum}입니다.");
                Console.ResetColor();
            }
        }
    }
}
