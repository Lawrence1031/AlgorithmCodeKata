namespace _26145
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int[] rewards = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[,] T = new int[N, N + M];

            for (int i = 0; i < N; i++)
            {
                string[] tmp = Console.ReadLine().Split(' ');
                for (int j = 0; j < N + M; j++)
                {
                    T[i, j] = int.Parse(tmp[j]);
                }
            }

            int[] result = new int[N + M];

            for (int i = 0; i < N; i++)
            {
                result[i] += rewards[i];
                for (int j = 0; j < N + M; j++)
                {
                    result[j] += T[i, j];
                    result[i] -= T[i, j];
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}