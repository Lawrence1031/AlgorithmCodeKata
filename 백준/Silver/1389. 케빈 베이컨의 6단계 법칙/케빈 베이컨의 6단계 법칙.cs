namespace _1389
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int[,] graph = new int[N + 1, N + 1];

            int baseNum = 5000;

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    if (i == j)
                    {
                        graph[i, j] = 0;
                    }
                    else
                    {
                        graph[i, j] = baseNum;
                    }
                }
            }

            for (int i = 0; i < M; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                graph[a, b] = graph[b, a] = 1;
            }

            for (int k = 1; k <= N; k++)
            {
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= N; j++)
                    {
                        if (graph[i, k] + graph[k, j] < graph[i, j])
                        {
                            graph[i, j] = graph[i, k] + graph[k, j];
                        }
                    }
                }
            }

            int minValue = baseNum * N;
            int person = 1;
            for (int i = 1; i <= N; i++)
            {
                int sum = 0;
                for (int j = 1; j <= N; j++)
                {
                    sum += graph[i, j];
                }

                if (sum < minValue)
                {
                    minValue = sum;
                    person = i;
                }
            }
            Console.WriteLine(person);
        }
    }
}