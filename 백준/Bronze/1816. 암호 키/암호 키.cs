namespace _1816
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<long> numbers = new List<long>();

            for (int i = 0; i < N; i++)
            {
                numbers.Add(long.Parse(Console.ReadLine()));
            }

            const int limit = 1000000;
            List<int> primes = GeneratePrimes(limit);

            foreach (long S in numbers)
            {
                Console.WriteLine(IsSuitable(S, primes) ? "YES" : "NO");
            }

        }
        static List<int> GeneratePrimes(int limit)
        {
            bool[] isPrime = new bool[limit + 1];
            for (int i = 2; i <= limit; i++)
            {
                isPrime[i] = true;
            }

            for (int p = 2; p * p <= limit; p++)
            {
                if (isPrime[p])
                {
                    for (int multiple = p * p; multiple <= limit; multiple += p)
                    {
                        isPrime[multiple] = false;
                    }
                }
            }

            List<int> primes = new List<int>();
            for (int i = 2; i <= limit; i++)
            {
                if (isPrime[i])
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        static bool IsSuitable(long S, List<int> primes)
        {
            foreach (int prime in primes)
            {
                if (S % prime == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}