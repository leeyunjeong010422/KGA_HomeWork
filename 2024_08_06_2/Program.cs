namespace 이진탐색
{
     //정렬이 되어 있는 자료구조에서 2분할을 통해 데이터를 탐색
     //단, 이진 탐색은 정렬이 되어 있는 자료에만 적용 가능
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 7, 9, 8, 6, 4, 2, 0 };
            //이진탐색은 배열이 정리가 되어 있어야 함

            foreach (int i in array)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();

            int index = BinarySearch(array, 2);
            Console.WriteLine($"결과: {index}"); //-1 출력

            Array.Sort(array);
            foreach (int i in array)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();

            int index1 = BinarySearch(array, 2);
            int index2 = Array.BinarySearch(array, 2);
            Console.WriteLine($"결과: {index1}");
            Console.WriteLine($"결과: {index2}");

        }

        public static int BinarySearch(int[] array, int target)
        {
            int result = -1;
            int min = 0;
            int max = array.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2; //중간 위치

                if (array[mid] < target)
                {
                    min = mid + 1;
                }
                else if (array[mid] > target)
                {
                    max = mid - 1;
                }
                else
                {
                    result = mid;
                    break;
                }
            }
            return result;
        }
    }
}
