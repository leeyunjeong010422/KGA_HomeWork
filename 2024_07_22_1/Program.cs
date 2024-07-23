namespace _2024_07_22_1
{
    internal class Program
    {

        class Monster
        {
            public string name;
            public int hp;

            public Monster()
            {
                name = "요괴";
                hp = 100;
            }

            public Monster(string _name, int _hp)
            {
                name = _name;
                hp = _hp;
            }

            public void PrintInfo()
            {
                Console.WriteLine($"{name} 몬스터의 HP는 {hp}");
            }
        }
        static void Main(string[] args)
        {
            Monster monster1 = new Monster();
            monster1.PrintInfo();


            Monster monster2 = new Monster("슬라임", 200);
            monster2.PrintInfo();
        }
    }
}
