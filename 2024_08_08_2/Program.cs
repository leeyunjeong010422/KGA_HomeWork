namespace 빌더패턴
{
    public class Program
    {
        static void Main(string[] args)
        {
            //안바꾸면 기본 내용들을 사용함
            OrcBuilder OrcBuilder1 = new OrcBuilder();
            OrcBuilder1.SetName("전사");
            OrcBuilder1.SetHP(300);

            OrcBuilder OrcBuilder2 = new OrcBuilder();
            OrcBuilder2.SetName("궁수");
            OrcBuilder2.SetWeapon("나무 활");
            OrcBuilder2.SetLevel(10);

            //OrcBuilder OrcBuilder3 = new OrcBuilder();
            //OrcBuilder3.SetName("주술사");
            //OrcBuilder3.SetWeapon("저주 받은 지팡이");
            //OrcBuilder3.SetArmor("의식복");
            //OrcBuilder3.SetHP(50);
            
            //체인메소드 사용하는 방법
            OrcBuilder OrcBuilder3 = new OrcBuilder();
            OrcBuilder3.SetName("주술사").SetWeapon("저주 받은 지팡이").SetArmor("의식복").SetHP(50);


            Orc[] orcs = new Orc[9];

            orcs[0] = OrcBuilder2.Build();
            orcs[1] = OrcBuilder3.Build();
            orcs[2] = OrcBuilder1.Build();

            OrcBuilder[] builders = new OrcBuilder[9];
            builders[0] = OrcBuilder1;
            builders[1] = OrcBuilder2;
            builders[2] = OrcBuilder3;

            for(int i = 0; i < orcs.Length; i++)
            {
                Console.WriteLine($"{orcs[i].name} {orcs[i].weapon} {orcs[i].arrmor} {orcs[i].level} {orcs[i].hp}");
            }
        }
    }

    public class OrcBuilder
    {
        public string name;
        public string weapon;
        public string arrmor;
        public int level;
        public int hp;

        public OrcBuilder()
        {
            name = "오크";
            weapon = "몽둥이";
            arrmor = "천옷";
            level = 1;
            hp = 100;
        }

        public Orc Build()
        {
            Orc orc = new Orc();

            orc.name = name;
            orc.weapon = weapon;
            orc.arrmor = arrmor;
            orc.level = level;
            orc.hp = hp;

            return orc;
        }

        public OrcBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public OrcBuilder SetWeapon(string weapon)
        {
            this.weapon = weapon;
            return this;
        }

        public OrcBuilder SetArmor(string armor)
        {
            this.arrmor = armor;
            return this;
        }

        public OrcBuilder SetLevel(int level)
        {
            this.level = level;
            return this;
        }

        public OrcBuilder SetHP(int hp)
        {
            this.hp = hp;
            return this;
        }       
    }
    public class Orc()
    {
        public string name;
        public string weapon;
        public string arrmor;
        public int level;
        public int hp;
    }
}
