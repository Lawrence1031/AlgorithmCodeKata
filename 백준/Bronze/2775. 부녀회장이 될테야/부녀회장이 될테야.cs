using System.Text;

namespace _2775
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            int[,] dp = new int[15, 15];

            for (int i = 1; i <= 14; i++)
            {
                dp[0, i] = i;
            }

            for (int i = 1; i <= 14; i++)
            {
                for (int j = 1; j <= 14; j++)
                {
                    dp[i, j] = dp[i, j - 1] + dp[i - 1, j];
                }
            }

            while (T > 0)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());

                sb.AppendLine(dp[k, n].ToString());
                T--;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}