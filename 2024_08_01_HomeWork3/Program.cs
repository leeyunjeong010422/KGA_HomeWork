namespace _2024_08_01_HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new ListGraph(8);

            graph.Connect(0, 3);

            graph.Connect(1, 3);

            graph.Connect(2, 6);

            graph.Connect(3, 0);
            graph.Connect(3, 1);
            graph.Connect(3, 5);

            graph.Connect(5, 3);
            graph.Connect(5, 6);
            graph.Connect(5, 7);

            graph.Connect(6, 2);
            graph.Connect(6, 5);

            graph.Connect(7, 5);

            for(int from = 0; from < 8; from++)
            {
                Console.WriteLine($"{from} 정점: ");
                
                for(int to = 0; to < 8; to++)
                {
                    if(graph.IsConnect(from, to))
                    {
                        Console.WriteLine($" {to} 정점");
                    }
                }
                Console.WriteLine();
            }
        }

        public abstract class Graph
        {
            public abstract void Connect(int from, int to);
            public abstract void DisConnect(int from, int to);
            public abstract bool IsConnect(int from, int to);
        }

        public class ListGraph : Graph
        {
            private List<int>[] graph;

            public ListGraph(int vertex)
            {
                graph = new List<int>[vertex];
                for (int i = 0; i < vertex; i++)
                {
                    graph[i] = new List<int>();
                }
            }

            public override void Connect(int from, int to)
            {
                graph[from].Add(to);
            }

            public override void DisConnect(int from, int to)
            {
                graph[from].Remove(to);
            }

            public override bool IsConnect(int from, int to)
            {
                return graph[from].Contains(to);
            }
        }
    }
}
