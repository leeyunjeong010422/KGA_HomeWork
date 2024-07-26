namespace 삼항연산자
{
    public class Program
    {
        static void Main(string[] args)
        {
            int left = 10;
            int right = 20;

            int bigger = left > right ? left : right;
            //left랑 right를 비교해서 맞으면 left를 출력하고 아니면 right를 출력
            //아래 코드랑 같은 거임

            if(left > right)
            {
                bigger = left;
            }
            else
            {
                bigger = right;
            }
           
        }
    }
}
