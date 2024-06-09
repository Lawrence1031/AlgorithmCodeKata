using System.Numerics;

namespace _14495
{
    internal class Program
    {
        static Dictionary<int, BigInteger> Fibo = new Dictionary<int, BigInteger>();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(fibonacci(n).ToString());
        }

        static BigInteger fibonacci(int n)
        {
            Fibo[0] = 0;
            Fibo[1] = 1;
            Fibo[2] = 1;
            Fibo[3] = 1;
            int cnt = 4;

            while (!Fibo.ContainsKey(n))
            {
                Fibo[cnt] = Fibo[cnt - 1] + Fibo[cnt - 3];
                cnt++;
            }

            return Fibo[n];
        }
    }
}
