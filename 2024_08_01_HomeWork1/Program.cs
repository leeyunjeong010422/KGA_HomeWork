namespace _2024_08_01_HomeWork1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MonsterData monsterData = new MonsterData();

            foreach (var monster in monsterData.Monsters)
            {
                Console.WriteLine($"{monster.Value.name}");
            }
        }

        public class MonsterData
        {
            public Dictionary<string, Monster> Monsters;
            public MonsterData()
            {
                Monsters = new Dictionary<string, Monster>();

                Monsters.Add("피카츄", new Monster("피카츄", 100));
                Monsters.Add("파이리", new Monster("파이리", 100));
                Monsters.Add("꼬부기", new Monster("꼬부기", 100));
                Monsters.Add("이상해씨", new Monster("이상해씨", 100));
                Monsters.Add("잠만보", new Monster("잠만보", 100));
            }

            public class Monster
            {
                public string name;
                public int hp;

                public Monster(string name,  int hp)
                {
                    this.name = name;
                    this.hp = hp;
                }
            }
        }
    }
}
