using System.Numerics;

namespace _1676
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int cnt = 0;
            BigInteger fact = 1;
            int limit = int.MaxValue;

            for (int i = 1; i <= N; i++)
            {
                fact *= i;

                if (fact > limit)
                {
                    while (fact > 10 && fact % 10 == 0)
                    {
                        fact /= 10;
                        cnt++;
                    }
                }
            }

            while (fact > 10 && fact % 10 == 0)
            {
                fact /= 10;
                cnt++;
            }

            Console.WriteLine(cnt);
        }
    }
}