namespace 병합정렬
//BigO: O(n log n)
//데이터를 2분할하여 정렬 후 합병
//데이터 갯수만큼의 추가적인 메모리가 필요
//분할 정복(Divide and Conquer) 기법을 사용하는 정렬 알고리즘으로,
//리스트를 반으로 나눈 후 재귀적으로 정렬한 다음, 정렬된 부분 리스트를 병합하여 최종적으로 정렬을 수행합니다.
{
    public class Program
    {
        static void Main(string[] args)
        {
           
        }
        public static void MergeSort(int[] array, int start, int end)
        {
            if (start == end) return; ;

            int mid = (start + end) / 2;
            MergeSort(array, start, end);
            MergeSort(array, mid + 1, end);
            Merge(array, start, mid, end);
        }

        public static void Merge(int[] array, int start, int mid, int end)
        {
            List<int> sortedList = new List<int>();
            int leftIndex = start;
            int rightIndex = mid + 1;

            //왼쪽 배열과 오른쪽 배열 중 하나라도 모두 소진될 때까지
            while (leftIndex <= mid && rightIndex <= end)
            {
                //왼쪽 배열의 요소가 더 작은 경우는
                if (array[leftIndex] < array[rightIndex])
                {
                    //추가 메모리 공간에 왼쪽 요소를 추가하고 한칸 이동
                    sortedList.Add(array[leftIndex]);
                    leftIndex++;
                }
                //오른쪽 배열의 요소가 더 작은 경우는
                else
                {
                    //추가 메모리 공간에 오른쪽 요소를 추가하고 한칸 이동
                    sortedList.Add(array[leftIndex]);
                    rightIndex++;
                }
            }

            //남아 있는 배열을 모두 나머지 뒷쪽으로 붙여주기
            //왼쪽 배열이 모두 소진됐을 때
            if (leftIndex > mid) 
            {
                while (rightIndex <= end)
                {
                    sortedList.Add(array[leftIndex]);
                    rightIndex++;
                }
            }
            //오른쪽 배열이 모두 소진됐을때
            else
            {
                while (leftIndex <= mid)
                {
                    sortedList.Add(array[leftIndex]);
                    leftIndex++;
                }
            }

            //추가적인 메모리에 정렬시켜두었던 것을 다시 원래 배열에다가 교체
            for (int i = 0; i< sortedList.Count; i++)
            {
                array[start + i] = sortedList[i];
            }
        }
    }
}
