namespace Nullable타입
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Nullable타입
            //값형식의 자료형들은 null을 가질 수 있음
            //값형식에도 null을 할당할 수 있는 Nullable타입
            bool? b = null;
            int? value = null;

            if(b != null) { Console.WriteLine("B가 있음"); }


            // Null 조건 연산자
            // ? 앞의 객체가 null인 경우 null반환
            // ? 앞의 객체가 null이 아닌 경우 접근

            Player player = new Player();
            player?.Die();


            // Null 병합연산자
            // ?? 앞의 객체가 null인 경우 ?? 뒤의 객체 반환
            // ?? 앞의 객체가 null이 아닌 경우 앞의 객체 반환

            int[] array = null;
            int lengh = array?.Length ?? 0;
        }
    }

    public class Player
    {
        public event Action OnDied;

        public void Die()
        {
            OnDied?.Invoke();
        }
    }
}
