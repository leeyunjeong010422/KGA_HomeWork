namespace _2024_07_26_HomeWork3_스택
{
    public class Program
    {

        //이게 (()이건 미완성으로 뜨는데 ())이건 완성으로 떠서,,, 일단 lms에 나온 예시들은 예시대로 뜨긴 뜹니다...
        static void Main(string[] args)
        {
            bool parethesesCheck = true;

            while (parethesesCheck)
            {
                Console.Write("검사할 괄호를 입력해주세요: ");
                string input = Console.ReadLine();

                if (IsParentheses(input))
                {
                    Console.WriteLine("완성");
                }
                else
                {
                    Console.WriteLine("미완성");
                }


            }
        }

        static bool IsParentheses(string input)
        {
            int firstParentheses = 0;
            int secondParentheses = 0;
            int thirdParentheses = 0;

            foreach (char parentheses in input)
            {
                if (parentheses == '(') firstParentheses++;
                else if (parentheses == '{') secondParentheses++;
                else if (parentheses == '[') thirdParentheses++;
                else if (parentheses == ')') firstParentheses--;
                else if (parentheses == '}') secondParentheses--;
                else if (parentheses == ']') thirdParentheses--;


                if (firstParentheses == 0 && secondParentheses == 0 && thirdParentheses == 0)
                {
                    return true;
                }
            }

            return false;
        }


    }
}
