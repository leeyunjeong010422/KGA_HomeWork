namespace _2024_07_23_HomeWork1
{
    public class Program
    {
        public abstract class Character
        {
            public string name;
            public int damage;

            public abstract void qSkill();
            public abstract void wSkill();
            public abstract void eSkill();
            public abstract void rSkill();

        }

        public class Ezreal : Character
        {
            public override void qSkill()
            {
                Console.WriteLine("신비한 화살(Mystic Shot)");
            }

            public override void wSkill()
            {
                Console.WriteLine("정수의 흐름(Essence Flux)");
            }

            public override void eSkill()
            {
                Console.WriteLine("비전 이동(Arcane Shift)");
            }

            public override void rSkill()
            {
                Console.WriteLine("정조준 일격(Trueshot Barrage)");
            }
        }

        public class Yuumi : Character
        {
            public override void qSkill()
            {
                Console.WriteLine("사르르탄(Prowling Projectile)");
            }

            public override void wSkill()
            {
                Console.WriteLine("너랑 유미랑!(You and Me!)");
            }

            public override void eSkill()
            {
                Console.WriteLine("슈우우웅(Zoomies)");
            }

            public override void rSkill()
            {
                Console.WriteLine("대단원(Final Chapter)");
            }
        }

        public class Zed : Character
        {
            public override void qSkill()
            {
                Console.WriteLine("예리한 표창(Razor Shuriken)");
            }

            public override void wSkill()
            {
                Console.WriteLine("살아있는 그림자(Living Shadow)");
            }

            public override void eSkill()
            {
                Console.WriteLine("그림자 베기(Shadow Slash)");
            }

            public override void rSkill()
            {
                Console.WriteLine("죽음의 표식(Death Mark)");
            }
        }

        public class Sona : Character
        {
            public override void qSkill()
            {
                Console.WriteLine("용맹의 찬가(Hymn of Valor)");
            }

            public override void wSkill()
            {
                Console.WriteLine("인내의 아리아(Aria of Perseverance)");
            }

            public override void eSkill()
            {
                Console.WriteLine("기민함의 노래(Song of Celerity)");
            }

            public override void rSkill()
            {
                Console.WriteLine("크레센도(Crescendo)");
            }
        }

        /* 추상클래스 과제 2. 오버로딩과 오버라이딩
           
        추상클래스: 공통적인 특성을 추출해서 신언한 클래스를 추상클래스로 하는데 부모, 
        실체 클래스가 자식으로 상속관계를 통해 추상클래스의 모든 특성을 물려받는 형태로 쓰인다.
        --> 실체 클래스들의 공통된 필드와 메소드의 이름을 통일할 목적
        --> 실체 클래스를 작성할 때 시간을 절약
        
        오버로딩: 같은 메소드라도 매개변수가 다르면 얼마든지 정의하고 사용할 수 있다.
        --> 메소드 이름이 같아야 한다.
        --> 리턴형이 같아도 되고 달라도 된다.
        --> 파라미터 개수가 달라야 한다.
        --> 파라미터 개수가 같을 경우, 데이터타입이 달라야 한다.

        오버라이딩: 상속 관계에 있는 클래스 간에 같은 이름의 메소드를 정의하는 기술이다. 
        만약 자식 클래스가 부모 클래스에서 선언된 것과 같은 메소드를 가질 때, 메소드 오버라이딩이라고 한다.
        --> 오버라이드 하고자 하는 메소드가 상위 클래스에 존재해야 한다.
        --> 메소드 이름이 같아야 한다.
        --> 메소드 파라미터 개수, 파라미터의 자료형이 같아야 한다.
        --> 메소드 리턴형이 같아야 한다.
        --> 상위 메소드와 동일하거나 내용이 추가되어야 한다.

         */
        static void Main(string[] args)
        {


        }
    }
}
