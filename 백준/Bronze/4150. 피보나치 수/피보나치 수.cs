using System.Numerics;

namespace _2748
{
    internal class Program
    {
        static Dictionary<int, BigInteger> Fibo = new Dictionary<int, BigInteger>();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(fibonacci(n));
        }

        static BigInteger fibonacci(int n)
        {
            Fibo[1] = 1;
            Fibo[2] = 1;
            int cnt = 3;

            while (!Fibo.ContainsKey(n))
            {
                Fibo[cnt] = Fibo[cnt - 1] + Fibo[cnt - 2];
                cnt++;
            }

            return Fibo[n];
        }
    }
}