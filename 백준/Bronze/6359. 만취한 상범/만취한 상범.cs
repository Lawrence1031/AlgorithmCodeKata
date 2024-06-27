namespace _6359
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int cnt = 0;

                for (int j = 1; j * j <= n; j++)
                {
                    cnt++;
                }

                Console.WriteLine(cnt);
            }
        }
    }
}
