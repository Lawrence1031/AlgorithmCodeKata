namespace _1236
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            char[,] castle = new char[N, M];
            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < M; j++)
                {
                    castle[i, j] = input[j];
                }
            }

            bool[] rowHasGuard = new bool[N];
            bool[] colHasGuard = new bool[M];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (castle[i, j] == 'X')
                    {
                        rowHasGuard[i] = true;
                        colHasGuard[j] = true;
                    }
                }
            }

            int rowGuardsNeeded = 0;
            int colGuardsNeeded = 0;

            for (int i = 0; i < N; i++)
            {
                if (!rowHasGuard[i])
                {
                    rowGuardsNeeded++;
                }
            }

            for (int j = 0; j < M; j++)
            {
                if (!colHasGuard[j])
                {
                    colGuardsNeeded++;
                }
            }

            int answer = Math.Max(rowGuardsNeeded, colGuardsNeeded);
            Console.WriteLine(answer);
        }
    }
}