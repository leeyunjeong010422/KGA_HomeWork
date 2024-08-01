using System.ComponentModel.Design;

namespace 작업일정계산기
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(4);
            queue.Enqueue(4);
            queue.Enqueue(12);
            queue.Enqueue(10);
            queue.Enqueue(2);
            queue.Enqueue(6);

            int day = 1;

            while(queue.Count > 0)
            {
                int remain = queue.Dequeue();
                if ()
                {

                }
            }
        }
    }
}
