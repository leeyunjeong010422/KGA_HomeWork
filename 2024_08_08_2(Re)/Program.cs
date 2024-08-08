namespace 빌드패턴2
{
    public class Program
    {
        static void Main(string[] args)
        {
            HamburgerBuilder bulgogiBurgerBuilder = new HamburgerBuilder();
            bulgogiBurgerBuilder.SetSource("달콤한 소스");
            bulgogiBurgerBuilder.SetPatty("불고기 패티");

            HamburgerBuilder shirmpBurgerBuilder = new HamburgerBuilder();
            shirmpBurgerBuilder.SetBread("호밀빵");
            shirmpBurgerBuilder.SetSource("마요네즈 소스");
            shirmpBurgerBuilder.SetPatty("새우 패티");

            //HamburgerBuilder bigmacBuilder = new HamburgerBuilder();
            //bigmacBuilder.SetBread("참깨빵");
            //bigmacBuilder.SetPatty("순쇠소기 패티 두장");
            //bigmacBuilder.SetSource("특별한 소스");
            //bigmacBuilder.SetVegetable("양상추");

            HamburgerBuilder bigmacBuilder = new HamburgerBuilder();
            bigmacBuilder.SetBread("참깨빵")
                .SetPatty("순쇠고기 패티 두장")
                .SetSource("특별한 소스")
                .SetVegetable("양상추");

            Hamburger[] burgers = new Hamburger[10];
            burgers[0] = bulgogiBurgerBuilder.Build();
            burgers[1] = shirmpBurgerBuilder.Build();
            burgers[2] = bigmacBuilder.Build();

            for (int i = 0; i < burgers.Length; i++)
            {
                Console.WriteLine($"{burgers[i].bread} {burgers[i].source} {burgers[i].patty} {burgers[i].vegetable}");
            }           
        }

        public class HamburgerBuilder
        {
            public string bread;
            public string source;
            public string patty;
            public string vegetable;

            public HamburgerBuilder()
            {
                this.bread = "기본빵";
                this.source = "케찹";
                this.patty = "고기패티";
                this.vegetable = "양상추";
            }

            public Hamburger Build()
            {
                Hamburger hamburger = new Hamburger();
                hamburger.bread = this.bread;
                hamburger.source = this.source;
                hamburger.patty = this.patty;
                hamburger.vegetable = this.vegetable;

                return hamburger;
            }

            public HamburgerBuilder SetBread(string bread)
            {
                this.bread = bread;
                return this;
            }

            public HamburgerBuilder SetSource(string source)
            {
                this.source = source;
                return this;
            }

            public HamburgerBuilder SetPatty(string patty)
            {
                this.patty = patty;
                return this;
            }

            public HamburgerBuilder SetVegetable(string vegetable)
            {
                this.vegetable = vegetable;
                return this;
            }
        }

        public class Hamburger
        {
            public string bread;
            public string source;
            public string patty;
            public string vegetable;
        }
    }
}
