using System.Text;

namespace _11725
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int>[] tree = new List<int>[N + 1];
            for (int i = 1; i <= N; i++)
            {
                tree[i] = new List<int>();
            }

            for (int i = 0; i < N - 1; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                tree[a].Add(b);
                tree[b].Add(a);
            }

            int[] parents = new int[N + 1];
            bool[] visited = new bool[N + 1];

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            visited[1] = true;

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                foreach (int neighbor in tree[current])
                {
                    if (!visited[neighbor])
                    {
                        visited[neighbor] = true;
                        parents[neighbor] = current;
                        queue.Enqueue(neighbor);
                    }
                }
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 2; i <= N; i++)
            {
                sb.AppendLine(parents[i].ToString());
            }

            Console.WriteLine(sb);
        }
    }
}