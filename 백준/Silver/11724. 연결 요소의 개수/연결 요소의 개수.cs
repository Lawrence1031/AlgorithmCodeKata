namespace _11724
{
    internal class Program
    {
        static List<int>[] graph;
        static bool[] visited;
        static int N;
        static int M;

        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            graph = new List<int>[N + 1];
            visited = new bool[N + 1];

            for (int i = 1; i <= N; i++)
            {
                graph[i] = new List<int>();
            }

            for (int i = 0; i < M; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int u = int.Parse(inputs[0]);
                int v = int.Parse(inputs[1]);

                graph[u].Add(v);
                graph[v].Add(u);
            }

            int cnt = 0;

            for (int i = 1; i <= N; i++)
            {
                if (!visited[i])
                {
                    DFS(i);
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }

        static void DFS(int n)
        {
            visited[n] = true;
            foreach (int i in graph[n])
            {
                if (!visited[i])
                {
                    DFS(i);
                }
            }
        }
    }
}