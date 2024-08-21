using System.Numerics;

namespace _9693
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = 1;
            while (true)
            {
                int N = int.Parse(Console.ReadLine());

                if (N == 0)
                {
                    return;
                }

                int answer = FindFact(N);

                Console.WriteLine($"Case #{cnt}: {answer}");

                cnt++;
            }
        }

        static int FindFact(int N)
        {
            int twoCnt = 0;
            int fiveCnt = 0;

            for (int i = 1; i <= N; i++)
            {
                int now = i;

                while (now % 2 == 0)
                {
                    twoCnt++;
                    now /= 2;
                }

                while (now % 5 == 0)
                {
                    fiveCnt++;
                    now /= 5;
                }
            }

            return Math.Min(twoCnt, fiveCnt);
        }
    }
}