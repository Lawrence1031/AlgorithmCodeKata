namespace _27986
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            var ranges = new (int L, int R)[M];
            for (int i = 0; i < M; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int L = int.Parse(inputs[0]);
                int R = int.Parse(inputs[1]);
                ranges[i] = (L, R);
            }

            int K = ranges.Min(r => r.R - r.L + 1);

            int[] X = new int[N];
            for (int i = 0; i < N; i++)
            {
                X[i] = (i % K) + 1;
            }

            Console.WriteLine(string.Join(" ", X));
        }
    }
}