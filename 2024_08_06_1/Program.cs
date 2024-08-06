namespace 순차탐색
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 7, 9, 8, 6, 4, 2, 0 };
            Console.Write("배열: ");
            foreach (int i in array)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();

            //데이터를 찾다가 못 찾으면 -1이 나옴
            int index = Util.IndexOf(array, 2);
            int index1 = Array.IndexOf(array, 3);
            int index2 = Array.IndexOf(array, 11); //-1출력

            Console.WriteLine($"순차탐색 결과 위치: {index}");
            Console.WriteLine($"순차탐색 결과 위치: {index1}");
            Console.WriteLine($"순차탐색 결과 위치: {index2}");
        }

        //원하는 위치를 찾도록 함수 구현
        public class Util
        {
            public static int IndexOf(int[] array, int target)
            {
                int result = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == target)
                    {
                        result = i;
                        break;
                    }
                }
                return result;
            }
        }
    }
}
