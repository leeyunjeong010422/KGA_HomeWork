namespace 선택정렬
//BigO: O(n^2)
//데이터 중 가장 작은 값부터 하나씩 선택하여 정렬
//간단한 정렬 알고리즘으로, 주어진 리스트에서 최소값을 선택하여 정렬되지 않은 부분과 정렬된 부분을 나누고,
//정렬되지 않은 부분에서 최소값을 선택하여 정렬된 부분에 추가하는 과정을 반복합니다.
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] select = { 3, 1, 5, 9, 7 };

            SelectionSort(select);

            Console.WriteLine("선택정렬");
            foreach(int a in select)
            {
                Console.WriteLine($"{a}");
            }            
        }

        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }

                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
