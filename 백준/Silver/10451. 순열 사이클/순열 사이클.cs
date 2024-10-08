namespace _10451
{
    internal class Program
    {
        static bool[] visited;

        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int test = 0; test < T; test++)
            {
                int N = int.Parse(Console.ReadLine());
                int[] permutation = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                
                int answer = CountCycles(permutation, N);
                Console.WriteLine(answer);
            }

        }
        static void DFS(int[] permutation, int current)
        {
            visited[current] = true;

            int next = permutation[current] - 1;
            if (!visited[next])
            {
                DFS(permutation, next);
            }
        }

        static int CountCycles(int[] permutation, int N)
        {
            visited = new bool[N];
            int cycleCount = 0;

            for (int i = 0; i < N; i++)
            {
                if (!visited[i])
                {
                    cycleCount++;
                    DFS(permutation, i);
                }
            }

            return cycleCount;
        }
    }
}