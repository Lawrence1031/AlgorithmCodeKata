namespace _6131
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;

            for (int i = 1; i <= 1000; i++)
            {
                for (int j = i + 1; j <= 1000; j++)
                {
                    if (i * i + n == j * j)
                    {
                        cnt++;
                    }
                }
            }

            Console.WriteLine(cnt);
        }
    }
}