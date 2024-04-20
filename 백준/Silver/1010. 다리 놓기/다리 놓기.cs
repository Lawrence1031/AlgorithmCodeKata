namespace _1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int[,] dp = new int[30, 30];

            for (int i = 0; i < 30; i++)
            {
                dp[i, 0] = 1;
                dp[i, i] = 1;
            }

            for (int i = 1; i < 30; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    dp[i, j] = dp[i - 1, j - 1] + dp[i - 1, j];
                }
            }

            for (int i = 0; i < T; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int N = int.Parse(inputs[0]);
                int M = int.Parse(inputs[1]);

                Console.WriteLine(dp[M, N]);
            }
        }
    }
}