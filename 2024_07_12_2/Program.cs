using System;

namespace _2024_07_12_2
{
    internal class Program
    {
        struct XYCoord
        {
            public short x;
            public short y;
        }

        struct Weapon
        {
            public int Dmg;
            public float Critical;
            public string Name;
        }

        enum carMaker { Honda, Audi, BMW, Kia }
        struct Car
        {
            public float maxSpeed;
            public int carNumber;
            public carMaker maker;
        }

        enum itemType { Armor=1, Weapons, Supplies }
        struct Item
        {
            public string Name;
            public int Price;
            public itemType Type;
        }

        static void Main(string[] args)
        {

            Weapon Sword = new Weapon();
            Sword.Dmg = 100;
            Sword.Critical = 20;
            Sword.Name = "sword";

            Weapon Katana = new Weapon();
            Katana.Dmg = 200;
            Katana.Critical = 40;
            Katana.Name = "katana";

            Item[] inventory = new Item[3];
            inventory[2].Name = "악몽의 꽃 견갑";
            inventory[2].Price = 500;
            inventory[2].Type = itemType.Armor;

            for (int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine($"Name: {inventory[i].Name}, Price: {inventory[i].Price}, Type: {inventory[i].Type}");
            }
        }
    }
}
