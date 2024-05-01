using System.Numerics;

namespace _2547
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                Console.ReadLine();
                int N = int.Parse(Console.ReadLine());
                BigInteger cnt = 0;

                for (int j = 0; j < N; j++)
                {
                    BigInteger candy = BigInteger.Parse(Console.ReadLine());
                    cnt += candy;
                }

                if (cnt % N == 0) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
        }
    }
}