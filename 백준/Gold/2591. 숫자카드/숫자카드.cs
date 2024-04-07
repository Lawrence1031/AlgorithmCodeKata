namespace _2591
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            int[] dp = new int[N.Length + 1];
            dp[0] = 1;

            for (int i = 1; i <= N.Length; i++)
            {
                dp[i] = 0;
                if (i - 1 >= 0 && IsValid(N, i - 1, 1))
                {
                    dp[i] += dp[i - 1];
                }
                if (i - 2 >= 0 && IsValid(N, i - 2, 2))
                {
                    dp[i] += dp[i - 2];
                }
            }

            Console.WriteLine(dp[N.Length]);
        }

        static bool IsValid(string s, int start, int length)
        {
            if (start + length > s.Length)
            {
                return false;
            }
            string sub = s.Substring(start, length);
            if (sub[0] == '0')
            {
                return false;
            }
            int value = int.Parse(sub);
            return value >= 1 && value <= 34;
        }
    }
}