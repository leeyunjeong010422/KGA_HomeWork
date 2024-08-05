

namespace 퀵정렬
    //BigO: 평균적으로 O(n log n), 최악의 경우 O(n^2)
    //하나의 피벗을 기준으로 작은 값과 큰값을 2분할하여 정렬
    //분할 정복(Divide and Conquer) 기법을 사용하는 정렬 알고리즘으로,
    //리스트를 기준값을 중심으로 분할한 후 재귀적으로 정렬합니다.
    //맨 앞 숫자를 피벗으로 두고 그 피벗보다 작은 수는 왼쪽으로 큰 수는 오른쪽으로 정렬함
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void QuickSort(int[] array, int start, int end)
        {
            int pivot = start; //가장 처음 요소를 기분으로 선정
            int left = pivot - 1; //큰 값을 오른쪽으로 보내는 왼쪽부터 출발할 위치
            int right = end; //작은 값을 왼쪽으로 보내는 오른쪽부터 출발할 위치

            while (left <= right) //둘이 교차할 때까지
            {
                //left는 더 큰 값을 찾을 때까지 오른쪽으로 가기 (right를 넘어 갈 필요 없음)
                while (array[left] <= array[pivot] && left < right)
                {
                    left++;
                }
                //right는 더 작은 값을 찾을 때까지 왼쪽으로 가기 (left를 넘어 갈 필요 없음)
                while (array[right] > array[pivot] && left <= right)
                {
                    right--;
                }

                //아직 교차 전이면
                if (left < right)
                {
                    //작은 값이랑 큰 값이랑 서로 교체해서 왼쪽엔 작은 값, 오른쪽엔 큰 값 두기
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                //교차를 했으면 => 반절로 나뉜 상황
                else
                {
                    //기준을 중간으로 옮기는 과정
                    int temp = array[right];
                    array[right] = array[pivot];
                    array[pivot] = temp;
                }
            }

            //피벗을 기준으로 왼쪽 부분은 작은 값들, 오른쪽 부분은 큰 값이 정렬
            QuickSort(array, start, right - 1); //작은 것들끼리 정렬하기
            QuickSort(array, right + 1, end); //큰 것들끼리 정렬하기



        }
    }
}
