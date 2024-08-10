namespace _14231
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            int[] boxes = new int[n];
            for (int i = 0; i < n; i++)
            {
                boxes[i] = int.Parse(inputs[i]);
            }

            int[] dp = new int[n];
            for (int i = 0; i < n; i++)
            {
                dp[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (boxes[j] < boxes[i])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
            }

            Console.WriteLine(dp.Max());
        }
    }
}