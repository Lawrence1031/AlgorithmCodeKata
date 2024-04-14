namespace _17218
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            string result = MakePassword(str1, str2);

            Console.WriteLine(result);
        }

        static string MakePassword(string str1, string str2)
        {
            int[,] dp = new int[str1.Length + 1, str2.Length + 1];

            for (int i = 1; i <= str1.Length; i++)
            {
                for (int j = 1; j <= str2.Length; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            int len = dp[str1.Length, str2.Length];
            char[] lcs = new char[len];
            int idx = len - 1;

            int x = str1.Length;
            int y = str2.Length;

            while (x > 0 && y > 0)
            {
                if (str1[x - 1] == str2[y - 1])
                {
                    lcs[idx] = str1[x - 1];
                    x--;
                    y--;
                    idx--;
                }
                else if (dp[x - 1, y] > dp[x, y - 1])
                {
                    x--;
                }
                else
                {
                    y--;
                }
            }

            return new string (lcs);
        }
    }
}