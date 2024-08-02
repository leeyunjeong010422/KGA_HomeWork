using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_08_02_LevelTest5
{
    public class Shop
    {
        List<Item> items;

        public Shop()
        {
            items = new List<Item>
            {
                new Longsword("롱소드", 400, "기본적인 검이다.", "(소유) 공격력 상승 15"),
                new Armor("천갑옷", 500, "얇은 갑옷이다.", "(소유) 방어력 상승 15"),
                new Candy("이상한 사탕", 800, "먹으면 신비한 효과를 일으킬 것 같다", "(사용) 체력 영구상승 300")
            };
        }

        public void ShowItem()
        {
            for(int i = 0; i < items.Count; i++)
            {
                items[i].ShowItem();
                Console.WriteLine();
            }          
        }
       
    }
}
