namespace 요세푸스순열 { 
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            Console.Write("n 값을 입력하세요: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("k 값을 입력하세요: ");
            int k = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                linkedList.AddLast(i);
            }

            while (linkedList.Count > 0)
            {
                for(int i = 1; i <= k; i++)
                {
                    LinkedListNode<int> node = linkedList.First;

                    if (i==k)
                    {
                        linkedList.RemoveFirst();
                        Console.Write($"{node.Value, 3}");
                    }
                    else
                    {
                        linkedList.RemoveFirst();
                        linkedList.AddLast(node.Value);
                    }
                }
            }
        }
    }
}
