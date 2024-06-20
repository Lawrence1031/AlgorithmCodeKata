namespace _9657
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            bool[] dp = new bool[N + 1];

            dp[0] = false;
            if (N >= 1) dp[1] = true;
            if (N >= 2) dp[2] = false;
            if (N >= 3) dp[3] = true;
            if (N >= 4) dp[4] = true;

            for (int i = 5; i <= N; i++)
            {
                dp[i] = !dp[i - 1] || !dp[i - 3] || !dp[i - 4];
            }

            Console.WriteLine(dp[N] ? "SK" : "CY");

        }
    }
}