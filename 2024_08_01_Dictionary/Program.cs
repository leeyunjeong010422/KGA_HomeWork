namespace _2024_08_01_Dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10000];
            students[5678] = new Student() { name = "홍길동", phone = 01012345678 };
            students[5432] = new Student() { name = "이순신", phone = 01098765432 };
            students[5432] = new Student() { name = "이순신", phone = 01011115432 };

            //찾고싶을 때
            Student find = students[01012345678];

            //key: 자료를 찾기 위한 지정값
            //value: 찾은 자료

            //해싱: 20억개나 되는 핸드폰 번호 -> 뒷자리만 쓰는 1만개로 뭉치기
            //해시함수: 너 핸드폰 번호 뭐야 -> 5678
            //탐색: table[hashed]

        }

        public class Student
        {
            public string name;
            public int phone;
            //필요정보
        }
    }
}
