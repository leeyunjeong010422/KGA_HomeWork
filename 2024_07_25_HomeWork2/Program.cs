using System;

namespace _2024_07_25_HomeWork2
{
    public class Program
    {
        public static void Main()
        {
            bool isOk = false;

            Console.Write("아이디를 입력하세요: ");

            while (!isOk)
            {
                string id = Console.ReadLine();

                isOk = id.IsAllowedID();

                if (isOk)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("ID가 유효합니다.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("ID에 허용되지 않는 특수문자가 있습니다. 다시 입력해 주세요: ");
                    Console.ResetColor();
                }
            }
        }
    }

    public static class Extension
    {
        public static bool IsAllowedID(this string id)
        {
            char[] specialCharacters = { '!', '@', '#', '$', '%', '^', '&', '*' };

            for (int i = 0; i < id.Length; i++)
            {
                for (int j = 0; j < specialCharacters.Length; j++)
                {
                    if (id[i] == specialCharacters[j])
                    {
                        return false; 
                    }
                }
            }

            return true; 
        }
    }
}
