namespace _2606
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            bool[,] graph = new bool[N + 1, N + 1];
            bool[] visited = new bool[N + 1];

            for (int i = 0; i < M; i++)
            {
                string input = Console.ReadLine();
                int from = int.Parse(input.Split(' ')[0]);
                int to = int.Parse(input.Split(' ')[1]);

                graph[from, to] = true;
                graph[to, from] = true;
            }

            int cnt =  DFS(graph, visited, 1);

            Console.WriteLine(cnt - 1);
        }

        static int DFS(bool[,] graph, bool[] visited, int node)
        {
            visited[node] = true;
            int cnt = 1;

            for (int i = 1; i < graph.GetLength(0); i++)
            {
                if (!visited[i] && graph[node, i])
                {
                    cnt += DFS(graph, visited, i);
                }
            }

            return cnt;
        }
    }
}