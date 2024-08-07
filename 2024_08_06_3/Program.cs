namespace 깊이우선탐색_너비우선탐색
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool[,] graph = new bool[8, 8]
            {
                { false, true, false, true, false, false, false, false },
                { true, false, true, true, false, true, true, false },
                { false, true, false, false, false, true, false, false },
                { false, true, false, false, false, false, false, false },
                { true, false, false, false, false, false, true, false },
                { false, true, true, false, false, false, true, false },
                { false, true, false, false, true, true, false, false },
                { false, false, false, false, false, false, false, false },
            };
        }

        // <깊이 우선 탐색 (Depth-First Search)>
        // 그래프의 분기를 만났을 때 최대한 깊이 내려간 뒤,
        // 분기의 탐색을 마쳤을 때 다음 분기를 탐색
        // 스택을 통해 구현
        // 지금 탐색하고 있는 경로에 메모리만 사용해도 동작 가능
        // 최단 경로 보장 X (한 번에 갈 수 있음에도 돌아서 감)
        // 트리에서 사용하기 좋음 (트리: 경로가 하나 밖에 없음)

        public static void DFS(bool[,] graph, int start, out bool[] visited, out int[] parent)
        {
            int size = graph.GetLength(0); //그래프의 정점 개수 사이즈 체크

            visited = new bool[size]; //탐색여부
            parent = new int[size]; //정점을 탐색한 정점이 누구인지

            //초기세팅 (처음으로 가져야 되는 값들)
            for (int i = 0; i < size; i++)
            {
                visited[i] = false;
                parent[i] = -1; //찾아진 적 없다는 의미로 -1로 작성
            }

            SearchNode(graph, start, visited, parent);  //처음 정점부터 탐색 시작
        }

        //해당 함수를 끝까지 찾으라고 시킴
        public static void SearchNode(bool[,] graph, int vertex, bool[] visited, int[] parent)
        {
            int size = graph.GetLength(0);  //정점의 갯수
            visited[vertex] = true; //탐색한 정점을 탐색 완료 표시

            //전체 정점들을 전부 확인하면서 
            for (int i = 0; i < size; i++)
            {
                if (graph[vertex, i] == true && //연결되어 있는 정점
                    visited[i] == false)        //찾은적 없는 정점
                {
                    parent[i] = vertex; //해당 정점을 탐색한 정점 표시
                    SearchNode(graph, i, visited, parent); //정점 탐색 시작
                }
            }
        }


        // <너비 우선 탐색 (Breadth-First Search)>
        // 그래프의 분기를 만났을 때 모든 분기들을 탐색한 뒤,
        // 다음 깊이의 분기들을 탐색
        // 큐를 통해 구현
        // 최단 경로 보장 O
        // 다음으로 탐색해야 하는 정점들까지 메모리에 보관하고 있어야 한다는 단점 존재
        // 그래프에서 사용하기 좋음

        public static void BFS(bool[,] graph, int start, out bool[] visited, out int[] parents)
        {
            int size = graph.GetLength(0);  //그래프 정점의 갯수
            visited = new bool[size];   //정점의 탐색 여부
            parents = new int[size];    //해당 정점을 누가 찾았는지 (역순으로 따라가면 경로)

            //초기설정
            for (int i = 0; i < size; i++)
            {
                visited[i] = false;
                parents[i] = -1;
            }

            Queue<int> queue = new Queue<int>();    //큐: 앞으로 찾아야 하는 정점들의 대기열
            queue.Enqueue(start);   //처음으로 탐색해야 하는 정점은 시작 정점
            visited[start] = true;  //탐색 여부 체크

            while (queue.Count > 0) //대기열에 아무것도 없을 때까지
            {
                int next = queue.Dequeue(); //다음으로 탐색해야 하는 정점이 나오게 됨

                for (int i = 0; i < size; i++)  //모든 정점들을 확인
                {
                    if (graph[next, i] &&       // 연결되어 있는 정점이며,
                        !visited[i])            // 방문한적 없는 정점
                    {
                        visited[i] = true;  //탐색 여부 체크
                        parents[i] = next;  //탐색하게 되는 정점을 표시 (해당 정점을 누가 찾았는지 표시)
                        queue.Enqueue(i);   //탐색해야 하는 정점을 대기열에 추가
                    }
                }
            }
        }
    }
}
