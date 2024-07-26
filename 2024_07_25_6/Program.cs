namespace Property
{
    public class Program
    {
        public class Player
        {
            private int mp;

            public int MP
            {
                get { return mp; }
                set { mp = value; }
            }

            public int AP { get; set; } //간소화 시켜서 이렇게 사용해도 같은 의미임
            //AP 멤버변수를 선언과 동시에 Get & Set 속성 생성

            private float rate;
            public int TotalDamage => (int)(AP * (1 + rate)); //아래 코드와 같은 의미임!!
           
            //public int TotalDamage()
            //{
            //    return (int)(AP * (1 + rate));
            //}

        }
        static void Main(string[] args)
        {
            Player player = new Player();
            player.MP = 1;  //프로퍼티 set
            int mp = player.MP; //프로퍼티 get

            player.AP = 2;
            int AP = player.AP;

            int totalDamage = player.TotalDamage;
        } 
    }
}
