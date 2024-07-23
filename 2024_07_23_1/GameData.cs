using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_07_23_1
{
    internal class GameData
    {
        public int gold;

        public void ShowGold()
        {
            Console.WriteLine($"현재까지 모은 골드는 {gold}");
        }
    }
}
