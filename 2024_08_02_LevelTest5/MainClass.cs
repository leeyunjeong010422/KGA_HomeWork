namespace _2024_08_02_LevelTest5
{
    public class MainClass
    {
        static int Gold = 3000;
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("==========상점메뉴==========");
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("2. 아이템 판매");
            Console.WriteLine("3. 아이템 확인");
            Console.WriteLine("4. 종료");
            Console.Write("메뉴를 선택하세요: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    BuyItem();
                    break;
                case "2":
                    SellItem();
                    break;
                case "3":
                    CheckItem();
                    break;
                default:
                    Console.WriteLine("다시 입력해주세요");
                    break;
            }

        }
        static void BuyItem()
        {
            Console.Clear();
            Console.WriteLine("================아이템 구매================");
            Console.WriteLine("보유한 골드: " + Gold + "G");
            Shop shop = new Shop();
            shop.ShowItem();

            Console.Write("구매할 아이템을 선택하세요. (뒤로가기 0): ");

            string inputBuy = Console.ReadLine();

            switch(inputBuy)
            {
                case "1":
            }
        }

        static void SellItem()
        {

        }

        static void CheckItem()
        {

        }
    }
}
