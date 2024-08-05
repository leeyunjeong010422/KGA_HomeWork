namespace 버블정렬
//BigO: O(n^2)
//인접한 두 원소를 비교하여 순서가 잘못되어 있다면 서로 교환하는 과정을 반복하여 정렬을 수행합니다.
//서로 인접한 데이터를 비교하여 정렬
//작은 수부터 큰 수대로 오름차순으로 정렬됨
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] bubble = { 3, 1, 5, 9, 7 };

            BubbleSort(bubble);

            Console.WriteLine("버블정렬");
            foreach (int a in bubble)
            {
                Console.WriteLine($"{a}");
            }
        }
        
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++) //맨뒤에서는 할 필요가 없으니까 -1해줌
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
