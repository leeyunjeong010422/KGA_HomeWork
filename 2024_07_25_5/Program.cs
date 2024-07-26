namespace _2024_07_25_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            float value = 2.7f;

            //Extension.Round(value);
            //value.Round(); //마치 AAA함수가 있는 것처럼 사용할 수 있음 (확장)

            Console.WriteLine(value.Round());

            string text = "Hello World";
            //text.WordCount();

            Console.WriteLine(text.CharCount('l'));
            Console.WriteLine(text.WordCount());
        }

    }

    public static class Extension
    {
        //확장메서드 만들기
        public static int Round(this float target) //어느 자료형에 쓸 거고 매개변수 명 짓기
        {
            if (target % 1 >= 0.5)
            {
                return (int)(target + 1);
            }
            else
            {
                return (int)(target);
            }
        }

        public static int WordCount(this string text) //글자 단어 수 세기
        {
            return text.Split(' ').Length;
        }

        public static int CharCount(this string text, char alphabet)
        {
            int count = 0;

            foreach (char c in text)
            {
                if (c == alphabet)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
