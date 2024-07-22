namespace _2024_07_22_HomeWork1
{
    internal class Program
    {

        class Chracter
        {
            private int level;
            private int hp;
            private int speed;
            private int attack;

            public void forward()
            {
                Console.WriteLine("전진합니다.");
            }

            public void backward()
            {
                Console.WriteLine("후진합니다");
            }

            public void leftTurn()
            {
                Console.WriteLine("좌회전합니다.");
            }

            public void rightTurn()
            {
                Console.WriteLine("우회전합니다.");
            }

            public void Attack()
            {
                Console.WriteLine("공격하였습니다.");
            }

            public void Attacked()
            {
                Console.WriteLine("피격당하였습니다.");
            }
        }
            static void Main(string[] args)
            {

            }
        }
    }
