namespace _19947
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int H = int.Parse(inputs[0]);
            int Y = int.Parse(inputs[1]);

            int[] dp = new int[Y + 1];
            dp[0] = H;

            for (int i = 1; i <= Y; i++)
            {
                dp[i] = (int)(dp[i - 1] * 1.05);

                if (i >= 3)
                {
                    dp[i] = Math.Max(dp[i], (int)(dp[i - 3] * 1.2));
                }

                if (i >= 5)
                {
                    dp[i] = Math.Max(dp[i], (int)(dp[i - 5] * 1.35));
                }
            }

            Console.WriteLine(dp[Y]);
        }
    }
}