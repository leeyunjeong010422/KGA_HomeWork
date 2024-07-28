namespace 큐
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Apple");
            queue.Enqueue("Banana");
            queue.Enqueue("Cherry");

            Console.WriteLine(queue.Peek()); // 1
            Console.WriteLine(queue.Dequeue()); // 2
            Console.WriteLine(queue.Count); // 3
        }
    }

}


