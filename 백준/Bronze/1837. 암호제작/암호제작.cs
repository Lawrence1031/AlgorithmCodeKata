using System.Numerics;

namespace _1837
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            BigInteger p = BigInteger.Parse(inputs[0]);
            int k = int.Parse(inputs[1]);

            var primes = GetPrimes(k);

            foreach (int prime in primes)
            {
                if (p % prime == 0)
                {
                    Console.WriteLine($"BAD {prime}");
                    return;
                }
            }

            Console.WriteLine("GOOD");
        }

        static List<int> GetPrimes(int k)
        {
            bool[] isPrime = new bool[k];
            List<int> primes = new List<int>();

            for (int i = 2; i < k; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i < k; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * 2; j < k; j+= i)
                    {
                        isPrime[j] = false;
                    }
                    primes.Add(i);
                }
            }

            return primes;
        }
    }
}