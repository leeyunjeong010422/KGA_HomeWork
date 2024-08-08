namespace _2024_08_08_HomeWork1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Potion potion = ItemFactory.Create<Potion>(ItemType.Potion);
            Weapon weapon = ItemFactory.Create<Weapon>(ItemType.Weapon);
            Armor armor = ItemFactory.Create<Armor>(ItemType.Armor);
            Food food = ItemFactory.Create<Food>(ItemType.Food);

            Console.WriteLine($"{potion.name}: {potion.price} 원");
            Console.WriteLine($"{weapon.name}: {weapon.price} 원");
            Console.WriteLine($"{armor.name}: {armor.price} 원");
            Console.WriteLine($"{food.name}: {food.price} 원");
        }

        public enum ItemType { Potion, Weapon, Armor, Food };

        public class ItemFactory
        {
            public static T Create<T>(ItemType type) where T : Item, new()
            {
                T item = new T();

                if (type == ItemType.Potion)
                {
                    item.name = "포션";
                    item.price = 1000;
                }
                else if (type == ItemType.Weapon)
                {
                    item.name = "무기";
                    item.price = 5000;
                }
                else if (type == ItemType.Armor)
                {
                    item.name = "갑옷";
                    item.price = 4000;
                }
                else if (type == ItemType.Food)
                {
                    item.name = "음식";
                    item.price = 2000;
                }
                else
                {
                    Console.WriteLine("없는 아이템입니다.");
                    return null;
                }

                return item; 
            }
        }


        public class Item
        {
            public string name;
            public int price;
        }

        public class Potion : Item { }
        public class Weapon : Item { }
        public class Armor : Item { }
        public class Food : Item { }
    }
}
