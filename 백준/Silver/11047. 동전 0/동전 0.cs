namespace _11047
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int N = int.Parse(s.Split(' ')[0]);
            int K = int.Parse(s.Split(' ')[1]);
            int[] coins = new int[N];

            for (int i = 0; i < N; i++)
            {
                coins[i] = int.Parse(Console.ReadLine());
            }

            int cnt = 0;
            for (int i = N - 1; i >= 0; i--)
            {
                if (coins[i] <= K)
                {
                    cnt += K / coins[i];
                    K %= coins[i];
                }
            }

            Console.WriteLine(cnt);
        }
    }
}