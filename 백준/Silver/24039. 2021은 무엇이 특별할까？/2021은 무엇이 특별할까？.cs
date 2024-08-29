namespace _24039
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int limit = 10000;
            List<int> primes = GeneratePrimes(limit);

            int specialNumber = 0;

            for (int i = 0; i < primes.Count - 1; i++)
            {
                int product = primes[i] * primes[i + 1];
                if (product > N)
                {
                    specialNumber = product;
                    break;
                }
            }

            Console.WriteLine(specialNumber);
        }

        static List<int> GeneratePrimes(int max)
        {
            bool[] isPrime = new bool[max + 1];
            for (int i = 2; i <= max; i++) isPrime[i] = true;

            for (int i = 2; i * i <= max; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= max; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            List<int> primes = new List<int>();
            for (int i = 2; i <= max; i++)
            {
                if (isPrime[i])
                {
                    primes.Add(i);
                }
            }

            return primes;
        }
    }
}