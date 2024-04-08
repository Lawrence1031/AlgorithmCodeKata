namespace _1463
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] dp = new int[N + 1];
            for (int i = 2; i <= N; i++)
            {
                dp[i] = dp[i - 1] + 1;
                if (i % 2 == 0)
                {
                    dp[i] = Math.Min(dp[i], dp[i / 2] + 1);
                }
                if (i % 3 == 0)
                {
                    dp[i] = Math.Min(dp[i], dp[i / 3] + 1);
                }
            }

            Console.WriteLine(dp[N]);
        }
    }
}