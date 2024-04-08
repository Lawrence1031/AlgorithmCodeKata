namespace _1012
{
    internal class Program
    {
        static int[,] graph;
        static bool[,] visited;
        static int M, N;
        static int[] dx = { -1, 1, 0, 0 };
        static int[] dy = { 0, 0, -1, 1 };
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            while (T > 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                M = int.Parse(input[0]);
                N = int.Parse(input[1]);
                int K = int.Parse(input[2]);

                graph = new int[M, N];
                visited = new bool[M, N];

                for (int i = 1; i <= K; i++)
                {
                    string[] position = Console.ReadLine().Split(' ');
                    int x = int.Parse(position[0]);
                    int y = int.Parse(position[1]);
                    graph[x, y] = 1;
                }

                int cnt = 0;
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (graph[i, j] == 1 && !visited[i, j])
                        {
                            DFS(i, j);
                            cnt++;
                        }
                    }
                }
                Console.WriteLine(cnt);

                T--;
            }
        }

        static private void DFS(int x, int y)
        {
            visited[x, y] = true;
            for (int i = 0; i < 4; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];
                if (nx >= 0 && nx < M && ny >= 0 && ny < N)
                {
                    if (graph[nx, ny] == 1 && !visited[nx, ny])
                    {
                        DFS(nx, ny);
                    }
                }
            }
        }
    }
}