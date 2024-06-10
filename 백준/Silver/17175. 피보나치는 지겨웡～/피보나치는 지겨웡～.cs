namespace _17175
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dp = new int[51];
            dp[0] = 1;
            dp[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                dp[i] = (dp[i - 1] + dp[i - 2] + 1) % 1000000007;
            }

            Console.WriteLine(dp[n]);
        }
    }
}