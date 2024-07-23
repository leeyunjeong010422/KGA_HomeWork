namespace _2024_07_23_2
{
    public class Inheritance
    {
        // 상속
        // 부모클래스의 모든 기능을 가지는 자식클래스를 설계하는 방법
        // is-a관계(~는~다): 부모클래스가 자식클래스를 포함하는 상위개념일 경우 상속관계가 적합함
        // 부모클래스를 상속하는 자식클래스에게 부모클래스의 모든 기능을 부여
        // class 자식클래스 : 부모클래스

        
    }

    public class Monster
    {
        //private int id;
        public string name;
        protected int hp;
        protected int attack;

        //public Monster(int id)
        //{
        //    this.id = id;
        //    this.name = "몬스터";
        //    this.hp = 100;
        //    this.attack = 50;
        //}

        public void TakeDamage(int damage)
        {
            hp -= damage;
            Console.WriteLine($"{name}이/가 데미지 {damage}를 받아 체력이 {hp}이 되었습니다.");
            if (hp < 0)
            {
                Die();
            }
        }

        private void Die()
        {
            Console.WriteLine($"{name}가 쓰러집니다");
        }

    }

    //public class Orc : Monster
    //{
    //    public Orc(int id) : base(id)
    //    {
    //        name = "오크";
    //        hp = 100;
    //        attack = 30;
    //    }
    //}

    public class Slime : Monster
    {

        public Slime()
        {
            name = "슬라임";
            hp = 30;
            attack = 10;
        }

    }

    public class Dragon : Monster
    {
        public Dragon()
        {
            name = "드래곤";
            hp = 500;
            attack = 100;
        }

        public static void Main()
        {       
            //Orc orc = new Orc(1); //Monster orc = new Orc(1);이랑 똑같음
            //orc.TakeDamage(50);

            Slime slime = new Slime();
            slime.TakeDamage(50);

            Dragon dragon = new Dragon();
            dragon.TakeDamage(50);
        }
    }

    
    public class Ainmal
    {
        public string name;
        public void Move()
        {

        }
    }
    
    public class Dog : Ainmal
    {
        
    }

    public class Cat : Ainmal
    {

    }

    public class Tiger : Ainmal
    {

    }

}

