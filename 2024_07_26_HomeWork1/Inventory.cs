using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_07_26_HomeWork1
{
    using static Item_관련.Program;

    public class Inventory
    {
        private List<Item> items = new List<Item>(9);

        public void ShowInventory()
        {           
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("<현재 인벤토리 상태>");
            Console.ResetColor();

            Console.WriteLine();
            for (int i = 0; i < 9; i++)
            {
                if (i < items.Count)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{items[i].Name}");
                    Console.ResetColor();
                }                
            }
            Console.WriteLine();

            if (items.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("인벤토리가 비어있습니다.");
                Console.WriteLine();
                Console.ResetColor();
            }
        }

        public void AddInventory(Random random)
        {
            if (items.Count >= 9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("인벤토리가 가득 찼습니다");
                Console.WriteLine();
                Console.ResetColor();               
                return;
            }

            Item newItem = AddItem(random);
            items.Add(newItem);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{newItem.Name} 추가");
            Console.WriteLine();
            Console.ResetColor();
        }

        public Item AddItem(Random random)
        {
            int itemType = random.Next(1, 6);

            switch (itemType)
            {
                case 1: return new Potion();
                case 2: return new Weapon();
                case 3: return new Armor();
                case 4: return new Accessory();
                default: return new Food();
            }
        }

        public void RemoveItem(int index)
        {
            if (index < items.Count)
            {
                string DeleteItem = items[index].Name;
                items.RemoveAt(index);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{DeleteItem} 제거");
                Console.WriteLine();                
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("아이템이 존재하지 않아 지울 수 없습니다.");
                Console.WriteLine();
                Console.ResetColor();
            }
        }


    }
}
