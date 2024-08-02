namespace _2024_08_02_LevelTest3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("배열을 입력해주세요(띄어쓰기 필수): ");
            string input = Console.ReadLine();

            //띄어쓰기를 기준으로 위에 입력 받은 문자열을 int형으로 변환하여 리스트에 저장
            List<int> array = input.Split(' ').Select(int.Parse).ToList();

            List<int> arrayReset = Solution(array);

            foreach (int c in arrayReset)
            {
                Console.Write(c + " ");
            }
        }

        public static List<int> Solution(List<int> array)
        {
            List<int> answer = new List<int>();

            if (array.Count > 0)
            {
                answer.Add(array[0]);
            }

            for (int i = 1; i < array.Count; i++)
            {
                if (array[i] != array[i - 1])
                {
                    answer.Add(array[i]);
                }
            }

            return answer;
        }
    }
}
