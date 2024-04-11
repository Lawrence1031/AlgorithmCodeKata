namespace _1697
{
    internal class Program
    {
        const int MaxValue = 100000;
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int N = int.Parse(input.Split(' ')[0]);
            int K = int.Parse(input.Split(' ')[1]);

            int result = FindRoute(N, K);
            Console.WriteLine(result);
        }

        static int FindRoute(int N, int K)
        {
            int[] time = new int[MaxValue + 1];
            bool[] visited = new bool[MaxValue + 1];
            Queue<int> queue = new Queue<int> ();

            queue.Enqueue(N);
            visited[N] = true;
            time[N] = 0;

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();

                if (current == K)
                {
                    return time[current];
                }

                HideAndSeek(current - 1, current, visited, time, queue);
                HideAndSeek(current + 1, current, visited, time, queue);
                HideAndSeek(current * 2, current, visited, time, queue);
            }

            return -1;
        }

        static void HideAndSeek(int next, int current, bool[] visited, int[] time, Queue<int> queue)
        {
            if (next >= 0 && next <= MaxValue && !visited[next])
            {
                queue.Enqueue(next);
                visited[next] = true;
                time[next] = time[current] + 1;
            }
        }
    }
}