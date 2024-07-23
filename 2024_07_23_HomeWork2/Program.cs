namespace _2024_07_23_HomeWork2
{
    public class Program
    {

        public enum MobType { Electric, Fire, Water, Grass }
        public class Trainer
        {
            public Monster[] monsters;

            public Trainer()
            {
                monsters = new Monster[6];
                monsters[0] = new Pikachu("피카츄", 10);
            }
            public void AddMonster(Monster monster)
            {
                for (int i = 0; i < monsters.Length; i++)
                {
                    if (this.monsters[i] == null)
                    {
                        this.monsters[i] = monster;
                        return;
                    }
                }
            }

            public void AllAttack()
            {
                foreach (Monster monster in monsters)
                {
                    if (monster != null)
                    {
                        monster.BaseAttack();
                    }
                }
            }
        }

        public abstract class Monster
        {
            public int level;
            public MobType mobType { get; set; }
            public string name;

            public abstract void BaseAttack();
        }

        class Pikachu : Monster
        {
            public override void BaseAttack()
            {
                Console.WriteLine("전광석화");
            }

            public Pikachu(string name, int level)
            {
                this.name = name;
                this.level = level;
                this.mobType = MobType.Electric;
            }

        }

        class Squirtle : Monster
        {
            public override void BaseAttack()
            {
                Console.WriteLine("물총발사");
            }

            public Squirtle(string name, int level)
            {
                this.name = name;
                this.level = level;
                this.mobType = MobType.Water;
            }
        }

        class Bulbasaur : Monster
        {
            public override void BaseAttack()
            {
                Console.WriteLine("덩굴채찍");
            }

            public Bulbasaur(string name, int level)
            {
                this.name = name;
                this.level = level;
                this.mobType = MobType.Grass;
            }
        }

        class Charmander : Monster
        {
            public override void BaseAttack()
            {
                Console.WriteLine("화염방사");
            }

            public Charmander(string name, int level)
            {
                this.name = name;
                this.level = level;
                this.mobType = MobType.Fire;
            }
        }
        static void Main(string[] args)
        {
            Trainer trainer = new Trainer();
            Charmander charmander = new Charmander("파이리", 5);
            trainer.AddMonster(charmander);
            trainer.AllAttack();
        }
    }
}
