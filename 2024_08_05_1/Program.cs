using System.Diagnostics;

namespace 재귀함수
{
    public class Program
    {
        //재귀(Recursion)
        //어떠한 것을 정의할 때 자기 자신을 참조하는 것
        //함수를 정의할 때 자기 자신을 이용하여 표현하는 방법
        //재귀함수를 사용하면 효율이 올라간다 (반절로 처리 가능)

        //재귀함수 조건
        //함수 내용 중 자기 자신 함수를 다시 호출해야 함
        //종료조건이 있어야 함 (꼬리 재귀)

        static void Main(string[] args)
        {
            Folder parentFolder = new Folder() { name = "부모폴더" };
            Folder childFolder1 = new Folder() { name = "자식1폴더" };
            Folder childFolder2 = new Folder() { name = "자식2폴더" };

            parentFolder.children.Add(childFolder1);
            parentFolder.children.Add(childFolder2);

            RemoveFolder(parentFolder);

            //재귀함수 결과 출력
            Factorial(5);

            //제곱 결과 출력
            int result = LoopPow(2, 16); //16번 돌아야 결과 확인 가능
            int result1 = Pow(2, 16); //4번 돌아야 결과 확인 가능

            //C#에 있는 스톱워치라는 기능으로 시간을 계산할 수 있음
            //하지만 시간으로는 정확하게 효율을 측정할 수는 없음
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            int result2 = LoopPow(2, 20000);
            Console.WriteLine(sw.ElapsedTicks);
            sw.Stop();

            sw.Reset();
            sw.Start();
            int result3 = Pow(2, 20000);
            Console.WriteLine(sw.ElapsedTicks);
            sw.Stop();


        }

        //반복으로 정의하기 힘든 내용도 재귀를 이용하면 가능
        //폴더를 지우는 건 for문으로 작성하게 되면 끝없이 반복해야 하는 단점이 있음
        public class Folder
        {
            public string name;
            public List<Folder> children = new List<Folder>();

            //이렇게 Folder안에 Remove() 메서드로 생성하여 사용할 수도 있음
            /*
                public void Remove()
                {
                    for (int i = 0; i < children.Count; i++)
                    {
                        children[i].Remove();
                    }
                    Console.WriteLine($"{name} 폴더를 삭제합니다."};
                }
             */
        }

        public static void RemoveFolder(Folder folder)
        {
            for (int i = 0; i < folder.children.Count; i++)
            {
                RemoveFolder(folder.children[i]);
            }
            Console.WriteLine($"{folder.name} 폴더를 삭제합니다.");
        }

        //팩토리얼
        //재귀사용이 안 좋은 상황
        public static int Factorial(int value)
        {
            if (value == 1)
                return 1;   //팩토리얼이 1이 되면 1을 출력한다는 꼬리재귀가 필요함 (종료 조건)

            return value * Factorial(value - 1);
        }

        //팩토리얼 for문으로 작성 가능
        public static int LoopFactorial(int value)
        {
            int result = 1;
            for (int i = value; i >= 1; i++)
            {
                result *= value;
            }
            return result;
        }

        //피보나치도 재귀를 사용하면 최악의 시간 효율을 보여줌 (O(2^n))
        //반복을 사용하는 게 나음
        public static int Fibonachi(int value)
        {
            if (value == 1 || value == 2) return 1;

            return Fibonachi(value - 1) + Fibonachi (value - 2);
        }

        //피보나치 반복문 사용
        public static int LoopFibonachi(int x)
        {
            int[] fibonachi = new int[x + 1];
            fibonachi[1] = 1;
            fibonachi[2] = 1;

            for (int i = 3; i <= x; i++)
            {
                fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];
            }
            return fibonachi[x];
        }

        //제곱
        //재귀함수를 사용하면 효율이 올라간다 (반절로 처리 가능)
        public static int LoopPow(int value, int pow) //O(pow)
        {
            int result = 1;
            for (int i = 0; i <= pow; i++)
            {
                result *= value;
            }
            return result;
        }

        public static int Pow(int value, int pow) //O(logPow) --> 얘가 더 빠름!!
        {
            if (pow == 1)
                return value;

            if (pow % 2 == 0)
            {
                return Pow(value * value, pow / 2);
            }
            else
            {
                return value * Pow(value * value, pow / 2);
            }
        }
    }
}
