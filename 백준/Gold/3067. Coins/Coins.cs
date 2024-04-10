namespace _3067
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int t = 0; t < T; t++)
            {
                int N = int.Parse(Console.ReadLine());
                string[] coinsInput = Console.ReadLine().Split(' ');
                int[] coins = new int[N];
                for (int i = 0; i < N; i++)
                {
                    coins[i] = int.Parse(coinsInput[i]);
                }

                int M = int.Parse(Console.ReadLine());
                int[] dp = new int[M + 1];
                dp[0] = 1;

                for (int i = 0; i < N; i++)
                {
                    for (int j = coins[i]; j <= M; j++)
                    {
                        dp[j] += dp[j - coins[i]];
                    }
                }

                Console.WriteLine(dp[M]);
            }
        }
    }
}