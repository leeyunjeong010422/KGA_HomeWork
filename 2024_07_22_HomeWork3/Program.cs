namespace _2024_07_22_HomeWork3
{
    internal class Program
    {

        class Trtrainer
        {
            public string name;
            public Monster[] monsters = new Monster[6];
            private int monstersCount = 0;

            public Trtrainer(string name)
            {
                this.name = name;
            }

            public void AddMonster(string name, int hp)
            {
                if (monstersCount < 6)
                {
                    monsters[monstersCount] = new Monster(name, hp);
                    monstersCount++;
                }
                else
                {
                    Console.WriteLine("6마리가 최대입니다.");
                }
            }

            public void MonsterInfo()
            {
                for (int i = 0; i < monstersCount; i++)
                {
                    Console.WriteLine($"{monsters[i].name} 몬스터의 HP는 {monsters[i].hp}이다.");
                }
            }
        }

        class Monster
        {
            public string name;
            public int hp;
            public Monster(string name, int hp)
            {
                this.name = name;
                this.hp = hp;
            }
        }
        static void Main(string[] args)
        {
            //과제 1.트레이너와 몬스터 제작하기
            //트레이너와 몬스터 클래스를 구현하시오.
            //트레이너는 최대 6마리의 몬스터를 가질 수 있다.
            //트레이너가 몬스터 생성 시 몬스터의 체력을 지정 값으로 초기화 해야 한다.
            //Main 함수에서 트레이너 인스턴스 생성 시, 트레이너의 이름을 초기화 해야 한다.

            Console.Write("트레이너 이름을 입력하세요: ");
            string trname = Console.ReadLine();

            Trtrainer trtrainer = new Trtrainer(trname);

            trtrainer.AddMonster("괴물1", 10);
            trtrainer.AddMonster("괴물2", 20);
            trtrainer.AddMonster("괴물3", 30);
            trtrainer.AddMonster("괴물4", 40);
            trtrainer.AddMonster("괴물5", 50);
            trtrainer.AddMonster("괴물6", 60);
            trtrainer.AddMonster("괴물7", 70);

            trtrainer.MonsterInfo();
        }
    }
}
