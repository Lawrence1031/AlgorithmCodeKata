using System.Collections.Generic;

namespace _25595
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];
            List<(int, int)> regions = new List<(int, int)>();
            (int x, int y) start = (-1, -1);


            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = int.Parse(inputs[j]);
                    if (matrix[i, j] == 2)
                    {
                        start = (i, j);
                    }
                    else if (matrix[i, j] == 1)
                    {
                        regions.Add((i, j));
                    }
                }
            }

            int[] dx = { -1, -1, 1, 1 };
            int[] dy = { -1, 1, -1, 1 };

            bool[,] visited = new bool[N, N];
            Queue<(int x, int y)> queue = new Queue<(int x, int y)>();
            queue.Enqueue(start);
            visited[start.x, start.y] = true;
            bool allCleared = true;

            while (queue.Count > 0)
            {
                var (x, y) = queue.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];
                    
                    if (IsInBounds(nx, ny, N) && matrix[nx, ny] == 1)
                    {
                        allCleared = false;
                        break;
                    }

                    if (IsInBounds(nx, ny, N) && !visited[nx, ny])
                    {
                        queue.Enqueue((nx, ny));
                        visited[nx, ny] = true;
                    }
                }

                if (!allCleared) break;
            }

            Console.WriteLine(allCleared ? "Lena" : "Kiriya");
        }

        static bool IsInBounds(int x, int y, int N)
        {
            return x >= 0 && x < N && y >= 0 && y < N;
        }

        static void RemoveRegions(int x, int y, int dx, int dy, int[,] matrix, int N)
        {
            int[] adjX = { x + dx, x };
            int[] adjY = { y, y + dy };

            for (int i = 0; i < 2; i++)
            {
                if (IsInBounds(adjX[i], adjY[i], N) && matrix[adjX[i], adjY[i]] == 1)
                    matrix[adjX[i], adjY[i]] = 0;
            }
        }
    }
}