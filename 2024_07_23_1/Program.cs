namespace _2024_07_23_1
{
    internal class Program
    {

        public static void Swap(int left, int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }

        public static void Swap1(ref int left, ref int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }

        static void Main(string[] args)
        {
            //GameData gameData = new GameData();
            //gameData.gold = 100;
            //gameData.ShowGold();

            int a = 10;
            int b = 20;

            int c = 10;
            int d = 20;

            Swap(a, b);
            Console.WriteLine($"a= {a} / b= {b}");

            Swap1(ref c, ref d);
            Console.WriteLine($"a= {c} / b= {d}");
        }
    }
}
