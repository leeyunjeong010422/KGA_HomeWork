namespace 삽입정렬
//BigO: O(n^2)
//데이터를 하나씩 꺼내어 정렬된 자료 중 적합한 위치에 삽입하여 정렬
//리스트를 정렬된 부분과 정렬되지 않은 부분으로 나눈 후,
//정렬되지 않은 부분의 원소를 정렬된 부분의 적절한 위치에 삽입하는 과정을 반복하여 정렬을 수행합니다.
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] insert = { 3, 1, 5, 9, 7 };

            InsertionSort(insert);

            Console.WriteLine("삽입 정렬");
            foreach (int a in insert)
            {
                Console.WriteLine(a);
            }
        }

        //public static void InsertionSort(int[] arr)
        //{
        //    int n = arr.Length;

        //    for (int i = 1; i < n; i++)
        //    {
        //        int key = arr[i];
        //        int j = i - 1;

        //        while (j >= 0 && arr[j] > key)
        //        {
        //            arr[j + 1] = arr[j];
        //            j--;
        //        }

        //        arr[j + 1] = key;
        //    }
        //}

        public static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 1; j > 0; j--)
                {
                    if (arr[j-1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j-1] = arr[j];
                        arr[j] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
