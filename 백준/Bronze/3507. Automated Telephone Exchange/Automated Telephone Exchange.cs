namespace _3507
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 200)
            {
                Console.WriteLine(0);
            }
            else
            {
                int cnt = 0;
                for (int i = 0; i <= 99; i++)
                {
                    for (int j = 0; j <= 99; j++)
                    {
                        if (i + j == n) cnt++;
                    }
                }

                Console.WriteLine(cnt);
            }
        }
    }
}