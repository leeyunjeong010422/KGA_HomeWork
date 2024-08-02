using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_08_02_LevelTest5
{
    public abstract class Item
    {
        public string Name { get; set; } 
        public int Price { get; set; }
        public string Description { get; set; }
        public string Effect { get; set; }

        public Item(string name, int price, string description, string effect)
        {
            Name = name;
            Price = price;
            Description = description;
            Effect = effect;
        }

        public abstract void ShowItem();
    }

    public class Longsword : Item
    {
        public Longsword (string name, int price, string description, string effect) 
            : base (name, price, description, effect) { }

        public override void ShowItem()
        {
            Console.WriteLine($"1. {Name}");
            Console.WriteLine($"가격: {Price}G");
            Console.WriteLine($"설명: {Description}");
            Console.WriteLine($"효과: {Effect}");
        }
    }

    public class Armor : Item
    {
        public Armor(string name, int price, string description, string effect)
            : base(name, price, description, effect) { }

        public override void ShowItem()
        {
            Console.WriteLine($"2. {Name}");
            Console.WriteLine($"가격: {Price}G");
            Console.WriteLine($"설명: {Description}");
            Console.WriteLine($"효과: {Effect}");
        }
    }

    public class Candy : Item
    {
        public Candy(string name, int price, string description, string effect)
            : base(name, price, description, effect) { }

        public override void ShowItem()
        {
            Console.WriteLine($"3. {Name}");
            Console.WriteLine($"가격: {Price}G");
            Console.WriteLine($"설명: {Description}");
            Console.WriteLine($"효과: {Effect}");
        }
    }
}
