namespace _2293
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
            dp[0] = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = coins[i]; j <= k; j++)
                {
                    dp[j] += dp[j - coins[i]];
                }
            }

            Console.WriteLine(dp[k]);
        }
    }
}