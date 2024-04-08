namespace _1260
{
    internal class Program
    {
        static Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        static List<int> dfsVisitedOrder = new List<int>();
        static List<int> bfsVisitedOrder = new List<int>();
        static HashSet<int> visited = new HashSet<int>();
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            int V = int.Parse(input[2]);

            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine().Split(' ');
                int from = int.Parse(input[0]);
                int to = int.Parse(input[1]);

                if (!graph.ContainsKey(from))
                {
                    graph[from] = new List<int>();
                }
                if (!graph.ContainsKey(to))
                {
                    graph[to] = new List<int>();
                }

                graph[from].Add(to);
                graph[to].Add(from);
            }

            foreach (var key in graph.Keys)
            {
                graph[key].Sort();
            }

            DFS(V);
            BFS(V);

            Console.WriteLine(string.Join(" ", dfsVisitedOrder));
            Console.WriteLine(string.Join(" ", bfsVisitedOrder));
        }

        static void DFS(int node)
        {
            if (visited.Contains(node))
            {
                return;
            }

            visited.Add(node);
            dfsVisitedOrder.Add(node);

            if (graph.ContainsKey(node))
            {
                foreach (var neighbor in graph[node])
                {
                    if (!visited.Contains(neighbor))
                    {
                        DFS(neighbor);
                    }
                }
            }
        }

        static void BFS(int startNode)
        {
            var queue = new Queue<int>();
            queue.Enqueue(startNode);
            visited.Clear();
            visited.Add(startNode);

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                bfsVisitedOrder.Add(node);

                if (graph.ContainsKey(node))
                {
                    foreach (var neighbor in graph[node])
                    {
                        if (!visited.Contains(neighbor))
                        {
                            visited.Add(neighbor);
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }
        }
    }
}