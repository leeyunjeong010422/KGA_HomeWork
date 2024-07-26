namespace Event
{
    internal class Program
    {
        public class Player
        {
            public event Action OnDied; //이벤트는 public 으로 해 줘야 함 다른 건 외부에서 사용하지 못하기 때문에
            public event Action OnTakeDamage;

            public void TakeDamage()
            {
                Console.WriteLine("플레이어가 데미지를 받았습니다");

                if (OnTakeDamage != null)
                {
                    OnTakeDamage();
                }
            }
            public void Die() 
            {
                Console.WriteLine("플레이어가 죽었습니다.");

                if (OnDied != null)
                {
                    OnDied(); //일련의 사건이 발생했을 때 이벤트 발생
                }
            }
        }

        public class UI
        {
            public void GameOver()
            {
                Console.WriteLine("게임오버 창을 띄웁니다");
            }
        }

        public class Sound
        {
            public void DeadSound()
            {
                Console.WriteLine("서글픈 음악을 출력합니다.");
            }
        }

        public class Monster
        {
            public void StopAttack()
            {

                Console.WriteLine("몬스터가 공격을 멈춥니다.");
            }
        }

        public class Camera
        {
            public void Shake()
            {
                Console.WriteLine("카메라가 흔들립니다.");
            }
        }
        static void Main(string[] args)
        {
            Player player = new Player();
            UI ui = new UI();
            Sound sound = new Sound();
            Monster monster = new Monster();

            Camera camera = new Camera();

            player.OnDied += ui.GameOver;
            player.OnDied += sound.DeadSound; 
            player.OnDied += monster.StopAttack;
            player.OnDied += camera.Shake;

            player.Die();

        }

    }
}
