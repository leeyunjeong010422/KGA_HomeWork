﻿namespace 팩토리패턴
{

    //상속을 통해서만 아이템 종류를 양산한다면
    //1. 유형별로 클래스가 너무 많이 생기게 된다
    //2. 각각의 클래스마다 가져야하는 값이나 구현방법들을 찾으면서 확인해야 한다

    //상속이 아닌 다형성확보를 통해서 만드는 경우
    //1. 매번 생성마다 각각의 필드를 지정해줘야 하는 과정 필요
    //2. 다른 값을 집어 넣어서 상이한 데이터를 가지는 같은 유형의 객체가 있을 수 있음
    public class Program
    {
        static void Main(string[] args)
        {
            Potion potion_T = ItemFactory.Instantiate<Potion>("포션");
            Potion bigPotion_T = ItemFactory.Instantiate<Potion>("큰포션");

            Item potion = ItemFactory.Instantiate("포션");
            Item bigPotion = ItemFactory.Instantiate("큰포션");
        }
    }

    public class ItemFactory
    {
        // 팩토리를 기반으로 다양한 효과들을 볼 수 있다.

        // 아이템 테이블과 같은 기능 추가 (객체생성 담당자 : 단일책임)
        // 견본품(프로토타입)
        // 추가과정(팩토리메서드)
        // 제작부품(빌더)

        public static T Instantiate<T>(string name) where T : Item
        {
            if (name == "포션")
            {
                Item potion = new Potion();
                potion.name = "포션";
                potion.weight = 3;
                potion.image = "유리병에 담긴 빨간액체";
                potion.hp = 30;
                return potion as T;
            }
            else if (name == "큰포션")
            {
                Item potion = new Potion();
                potion.name = "큰포션";
                potion.weight = 10;
                potion.image = "뚱뚱한 유리병에 담긴 빨간액체";
                potion.hp = 100;
                return potion as T;
            }
            else
            {
                Console.WriteLine("해당 이름의 아이템이 없습니다.");
                return null as T;
            }
        }
        //enum { 큰포션, 작은포션, 노랑포션}
        public static Item Instantiate(string name)
        {
            if (name == "포션")
            {
                Item potion = new Potion();
                potion.name = "포션";
                potion.weight = 3;
                potion.image = "유리병에 담긴 빨간액체";
                potion.hp = 30;
                return potion;
            }
            else if (name == "큰포션")
            {
                Item potion = new Potion();
                potion.name = "큰포션";
                potion.weight = 10;
                potion.image = "뚱뚱한 유리병에 담긴 빨간액체";
                potion.hp = 100;
                return potion;
            }
            else
            {
                Console.WriteLine("해당 이름의 아이템이 없습니다.");
                return null;
            }
        }
    }

    public class Item
    {
        public string name;
        public int weight;
        public string image;
        public int hp;

        public Item ()
        {
            this.name = "아이템";
            this.weight = 1;
            this.image = "기본 이미지";
        }
    }

    public class Potion : Item
    {
        public Potion()
        {
            this.name = "포션";
            this.weight = 3;
            this.image = "빨간색 유리병에 담긴 이미지";
        }
    }
}
