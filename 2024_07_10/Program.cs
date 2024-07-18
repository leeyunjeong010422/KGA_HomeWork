using System;

namespace _2024_07_10
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //과제 1.이름 입력받아 출력
            //이름을 입력받아, 반갑다고 출력하는 프로그램을 작성해주세요
            //"당신의 이름을 입력해주세요" 출력
            //다음줄에서 이름을 입력 받기
            //"(방금입력받은이름)님, 반갑습니다" 출력하는 프로그램

            Console.WriteLine("당신의 이름을 입력해주세요");
            string name = Console.ReadLine();
            Console.WriteLine($"{name}님, 반갑습니다.");


            //과제 2.두 수의 합 출력
            //두 실수를 유저로부터 한줄씩 입력받아, 마지막 줄엔 둘의 합을 출력해보아요
            //"첫 번째 실수를 입력하여 주세요"
            //다음 줄에서 입력 받기
            //"두 번째 실수를 입력하여 주세요"
            //다음 줄에서 두번째 수 입력 받기
            //"두 수의 합은 ??? 입니다" 형식으로 출력

            Console.WriteLine("===============================================");

            Console.WriteLine("첫 번째 실수를 입력하여 주세요.");
            string input_1 = Console.ReadLine();
            float num_1;
            bool success1 = float.TryParse(input_1, out num_1);

            Console.WriteLine("두 번째 실수를 입력하여 주세요.");
            string input_2 = Console.ReadLine();
            float num_2;
            bool success2 = float.TryParse(input_2, out num_2);

            float sum = num_1 + num_2;
            Console.WriteLine($"두 수의 합은 {sum}입니다.");

            //과제 3.두 정수의 몫과 나머지 출력
            //두 정수를 유저로부터 입력 받고, 몫과 나머지를 출력해보자
            //"나눗셈을 진행할 첫 번째 수를 입력하여 주세요: " 출력
            //같은 줄에서 입력 받기
            //그 다음줄로 와서 "두번째 나눌 수를 입력해주세요: " 출력
            //위 출력과 같은 줄에서 입력을 받기
            //그 다음 줄에서 "(첫째수)와 (둘째수)의 나눗셈 결과, 몫은 (몫) 나머지는 (나머지)" 출력

            Console.WriteLine("===============================================");

            Console.Write("나눗셈을 진행할 첫 번째 수를 입력하여 주세요: ");
            string intput_3 = Console.ReadLine();
            int division_1;
            bool success3 = int.TryParse(intput_3, out division_1);

            Console.Write("두 번째 나눌 수를 입력해주세요: ");
            string intput_4 = Console.ReadLine();
            int division_2;
            bool success4 = int.TryParse(intput_4, out division_2);

            int quotient = division_1 / division_2;
            int remainder = division_1 % division_2;
            Console.WriteLine($"{division_1}와 {division_2}의 나눗셈 결과, 몫은 {quotient} 나머지는 {remainder} ");

            //과제 4.입력된 세 정수의 합 및 곱 출력
            //세 정수를 유저로부터 입력 받고, 앞 두개 숫자를 더하고 세번째 수는 곱하는 프로그램을 작성하되, “첫째수 더하기 둘째수에 셋째수를 곱한 값은 X 입니다” 라고 나오는 프로그램 제작.
            //"첫째 정수 입력" 출력
            //같은 줄 혹은 다음 줄에 입력 받기
            //"둘째 정수 입력" 출력
            //같은 줄 혹은 다음 줄에 입력 받기
            //"셋째 정수 입력" 출력
            //같은 줄 혹은 다음 줄에 입력 받기
            //“첫째수 더하기 둘째수에 셋째수를 곱한 값은(결과값) 입니다” 출력

            Console.WriteLine("===============================================");

            Console.Write("첫째 정수 입력: ");
            string intput_5 = Console.ReadLine();
            int num_3;
            bool success5 = int.TryParse(intput_5, out num_3);

            Console.Write("둘째 정수 입력: ");
            string intput_6 = Console.ReadLine();
            int num_4;
            bool success6 = int.TryParse(intput_6, out num_4);

            Console.Write("셋째 정수 입력: ");
            string intput_7 = Console.ReadLine();
            int num_5;
            bool success7 = int.TryParse(intput_7, out num_5);

            int hap = num_3 + num_4;
            int result = hap * num_5;
            Console.WriteLine($"첫째수 더하기 둘째수에 셋째수를 곱한 값은 {result} 입니다");

        }
    }
}
