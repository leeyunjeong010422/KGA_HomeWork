using System;

namespace _2024_07_12_3
{
    internal class Program
    {
        struct Weapon
        {
            public string name;
        }

        struct Soldier
        {
            public Weapon[] weapons;
            public int useWeapon;
        }

        static void Main(string[] args)
        {
            Soldier soldier = new Soldier();
            soldier.weapons = new Weapon[3];

            soldier.weapons[0] = new Weapon { name = "칼" };
            soldier.weapons[1] = new Weapon { name = "활" };
            soldier.weapons[2] = new Weapon { name = "총" };
            soldier.useWeapon = 0;

            while (true)
            {
                Console.WriteLine($"현재 당신이 가지고 있는 무기는 \"{soldier.weapons[soldier.useWeapon].name}\"입니다.");
                Console.WriteLine();
                Console.WriteLine("바꿀 수 있는 무기 종류");
                for (int i = 0; i < soldier.weapons.Length; i++)
                {
                    Console.WriteLine($"{i+1}: {soldier.weapons[i].name}");
                }
                Console.WriteLine();
                Console.WriteLine("어떤 무기로 바꾸시겠습니까?");
                Console.Write("무기를 변경하려면 1~3 사이 숫자를 입력하세요: ");
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine();
                ChangeWeapon(value, ref soldier);             
            }
        }

        static void ChangeWeapon(int value, ref Soldier soldier)
        {           

            bool Ok = false;

            while (!Ok)
            {
                if (value < 1 || value > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("변경할 수 있는 무기가 없습니다.");
                    Console.Write("1~3 사이 숫자로 다시 입력해주세요: ");
                    Console.ResetColor();
                    value = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    continue;
                }
               
                if (value - 1 == soldier.useWeapon)
                {
                    Console.Write("현재 들고 있는 무기와 동일합니다. 다시 입력해주세요: ");                    
                    value = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    continue;
                }

                soldier.useWeapon = value - 1;
                Console.ForegroundColor= ConsoleColor.DarkYellow;
                Console.WriteLine($"무기가 교체되었습니다: {soldier.weapons[soldier.useWeapon].name}");
                Console.ResetColor();
                Console.WriteLine();
                Ok = true;
            }
        }
    }
}
