using System;

namespace _2024_07_12_1
{
    internal class Program
    {
        enum Place { 마을 = 1, 사냥터, 상점 }
        enum State { idle=1, run, walk, die=9}
        static void Main(string[] args)
        {
            #region 과제1 열거형 리팩토링           

            Console.WriteLine("1. 마을 | 2. 사냥터 | 3. 상점");
            Console.Write("이동할 장소를 선택해주세요: ");
            Place placeNum;

            if (Enum.TryParse(Console.ReadLine(), out placeNum))
            {

                switch (placeNum)
                {
                    case Place.마을:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("마을로 이동합니다");
                        Console.ResetColor();
                        break;
                    case Place.사냥터:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("사냥터로 이동합니다");
                        Console.ResetColor();
                        break;
                    case Place.상점:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("상점으로 이동합니다");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("1,2,3 어느것도 아니에요");
                        Console.ResetColor();
                        break;
                }
            }

            #endregion

            #region 과제2 상태를 열거형으로 구현
            //플레이어의 현재 행동이 int state 로 정의되어 있습니다.
            //state변수에 1이 담겨 있으면 idle, 2가 담겨있으면 run, 3이 들어있으면 walk ,
            //9가 담겨있으면 죽은 상태 입니다.열거형을 활용하여 해당 코드를 어떻게 수정할 수 있는지 작성해주세요.
            //유저에게 콘솔 입력으로 1,2,3,9 외의 입력이 들어오면, 옳지 못한 입력이라고 출력 후,
            //다시 입력을 요구하는 기능을 만드세요
            Console.WriteLine();
            Console.WriteLine("===================================================");
            Console.WriteLine();


            bool stateOk = true;

            while (stateOk)
            {

                Console.Write("플레이어의 현재 행동은 무엇인가요?: ");
                State state;
                if (Enum.TryParse(Console.ReadLine(), out state))
                {

                    switch (state)
                    {
                        case State.idle:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("idle 상태입니다.");
                            Console.ResetColor();
                            stateOk = false;
                            break;

                        case State.run:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("run 상태입니다.");
                            Console.ResetColor();
                            stateOk = false;
                            break;

                        case State.walk:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("walk 상태입니다.");
                            Console.ResetColor();
                            stateOk = false;
                            break;

                        case State.die:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("플레이어는 죽은 상태입니다.");
                            Console.ResetColor();
                            stateOk = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("옳지 못한 입력입니다. 다시 입력해주세요.");
                            Console.ResetColor();
                            Console.WriteLine();
                            break;
                    }
                }
            }

            #endregion
        }
    }
}
