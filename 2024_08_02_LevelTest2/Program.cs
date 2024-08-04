namespace _2024_08_02_LevelTest2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Monster[] monsters = new Monster[5];
            //Monster[] monsters = new Monster[10];
            monsters[0] = new Pikachu();
            monsters[1] = new Charmander();
            monsters[2] = new Squirtle();
            monsters[3] = new Bulbasaur();
            monsters[4] = new Pikachu("털뭉치");
            //monsters[5] = new Charmander("바보");

            foreach (Monster monster in monsters)
            {
                Console.WriteLine($"{monster.Name} 공격해!");
                monster.Attack();
                Console.WriteLine();
            }
        }
        public abstract class Monster
        {
            //protected string name;
            public string Name {  get; set; }

            public Monster(string name)
            {
                Name = name;
            }

            public abstract void Attack();
        }

        public class Pikachu : Monster
        {
            public Pikachu() : base("피카츄") { }

            public override void Attack()
            {
                Console.WriteLine("백만볼트!");
            }

            public Pikachu(string name) : base(name) { }
        }

        public class Charmander : Monster
        {
            public Charmander() : base("파이리") { }

            public override void Attack()
            {
                Console.WriteLine("화염방사!");
            }

            public Charmander(string name) : base(name) { }
        }

        public class Squirtle : Monster
        {
            public Squirtle() : base("꼬북이") { }

            public override void Attack()
            {
                Console.WriteLine("물총발사!");
            }

            public Squirtle(string name) : base(name) { }
        }

        public class Bulbasaur : Monster
        {
            public Bulbasaur() : base("이상해씨") { }

            public override void Attack()
            {
                Console.WriteLine("덩굴채찍!");
            }

            public Bulbasaur(string name) : base(name) { }
        }
    }
}
