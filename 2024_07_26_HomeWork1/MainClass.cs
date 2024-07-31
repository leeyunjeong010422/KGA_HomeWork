namespace _2024_07_26_HomeWork1;

public class MainClass
{
    //string? input = Console.ReadLine(); 이 코드에 원래 안 그랬는데
    //string?으로 null 값일 경우일 때를 생각해야 하는지 모르겠어요,,,
    //지금까지 한 번도 안 썼는데 갑자기 떠서 궁금해요

    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        Random random = new Random();

        while (true)
        {
            inventory.ShowInventory();
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("0: 랜덤으로 아이템 추가");
            Console.WriteLine("1~9 해당하는 숫자의 아이템 제거");
            Console.Write("입력하세요: ");
            string? input = Console.ReadLine();

            if (input == "0")
            {
                inventory.AddInventory(random);
            }

            else if(int.TryParse(input, out int index) && index >= 1 && index <= 9)
            {
                inventory.RemoveItem(index - 1);
            }
        }
    }
}
