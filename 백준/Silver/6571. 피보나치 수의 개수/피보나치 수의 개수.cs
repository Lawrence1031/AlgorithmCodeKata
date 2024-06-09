using System.Numerics;

namespace _6571
{
    internal class Program
    {
        static List<BigInteger> Fibo = new List<BigInteger>();
        static void Main(string[] args)
        {
            Fibonacci();
            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                BigInteger a = BigInteger.Parse(inputs[0]);
                BigInteger b = BigInteger.Parse(inputs[1]);

                if (a == 0 && b == 0)
                {
                    return;
                }

                int cnt = FindFibonacciCnt(a, b);
                Console.WriteLine(cnt);
            }
        }

        static void Fibonacci()
        {
            Fibo.Add(1);
            Fibo.Add(2);

            while (true)
            {
                BigInteger nextFibo = Fibo[Fibo.Count - 1] + Fibo[Fibo.Count - 2];
                if (nextFibo > BigInteger.Pow(10, 100))
                {
                    break;
                }
                Fibo.Add(nextFibo);
            }
        }

        static int FindFibonacciCnt(BigInteger a,  BigInteger b)
        {
            int start = 0;
            while (start < Fibo.Count && Fibo[start] < a)
            {
                start++;
            }

            int end = Fibo.Count - 1;
            while (end >= 0 && Fibo[end] > b)
            {
                end--;
            }

            if (start > end)
            {
                return 0;
            }

            return end - start + 1;
        }
    }
}