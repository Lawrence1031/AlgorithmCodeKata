namespace _8320
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int cnt = 0;

            for (int i = 1; i <= N; i++)
            {
                for (int j = i; j <= N; j++)
                {
                    if (i * j <= N)
                    {
                        cnt++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(cnt);
        }
    }
}