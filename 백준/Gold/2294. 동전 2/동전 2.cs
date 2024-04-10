namespace _2294
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input.Split(' ')[0]);
            int k = int.Parse(input.Split(' ')[1]);
            int[] coins = new int[n];

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                coins[i] = int.Parse(input);
            }

            int[] dp = new int[k + 1];
            for (int i = 1; i <= k; i++)
            {
                dp[i] = k + 1;
            }
            dp[0] = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = coins[i]; j <= k; j++)
                {
                    dp[j] = Math.Min(dp[j], dp[j - coins[i]] + 1);
                }
            }

            Console.WriteLine(dp[k] > k ? -1 : dp[k]);
        }
    }
}