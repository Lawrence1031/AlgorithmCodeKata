namespace _14040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = input.Length;

            bool[,] dp = new bool[n, n];
            int maxLength = 1;

            for (int i = 0; i < n; i++)
            {
                dp[i, i] = true;
            }

            for (int i = 0; i < n - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    dp[i, i + 1] = true;
                    maxLength = 2;
                }
            }

            for (int i = 3; i <= n; i++)
            {
                for (int j = 0; j < n - i + 1; j++)
                {
                    int k = j + i - 1;
                    if (input[j] == input[k] && dp[j + 1, k - 1])
                    {
                        dp[j, k] = true;
                        maxLength = i;
                    }
                }
            }

            Console.WriteLine(maxLength);
        }
    }
}