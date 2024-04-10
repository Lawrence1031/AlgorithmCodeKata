using System.Runtime.Intrinsics.Arm;

namespace _2579
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] steps = new int[N];

            for (int i = 0; i < N; i++)
            {
                steps[i] = int.Parse(Console.ReadLine());
            }

            if (N == 1)
            {
                Console.WriteLine(steps[0]);
                return;
            }

            int[] dp = new int[N + 1];
            dp[0] = 0;
            dp[1] = steps[0];

            if (N > 1)
            {
                dp[2] = steps[0] + steps[1];
            }

            for (int i = 3; i <= N; i++)
            {
                dp[i] = Math.Max(dp[i - 2], dp[i - 3] + steps[i - 2]) + steps[i - 1];
            }


            Console.WriteLine(dp[N]);
        }
    }
}