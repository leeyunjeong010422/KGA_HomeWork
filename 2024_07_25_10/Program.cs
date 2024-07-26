using System.Text;

namespace string의_불변성
{
    public class Program
    {
        public class TestClass
        {
            public int value;
        }

        static void Main(string[] args)
        {
            TestClass left = new TestClass() { value = 20};
            TestClass right = left;
            right.value = 20;

            Console.WriteLine(left.value); //right가 바뀌니까 left도 바뀜

            string a = "안녕하세요";
            string b = a;
            b = "Hello";

            Console.WriteLine(a); //b가 바뀌어도 a는 바뀌지 않음
            //stirng은 불변성이라는 특성을 가지고 있음 (class이지만 값형식처럼 사용)
            Console.WriteLine(b);

            StringBuilder sb = new StringBuilder();
            sb.Append("asd");
            sb.AppendLine("dsfsdhfjks");
            sb[0] = 'f';
            sb.Replace('s', 'd');

            Console.WriteLine(sb.ToString());
        }
    }
}
