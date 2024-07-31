namespace Item_관련;
    public class Program
    {
        public abstract class Item
        {
            public abstract string Name { get; }
        }

        public class Potion : Item
        {
            public override string Name => "포션";
        }

        public class Weapon : Item
        {
            public override string Name => "무기";
        }

        public class Armor : Item
        {
            public override string Name => "방어구";
        }

        public class Accessory : Item
        {
            public override string Name => "악세서리";
        }

        public class Food : Item
        {
            public override string Name => "음식";
        }

    }


