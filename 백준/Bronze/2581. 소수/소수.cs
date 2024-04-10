namespace _2581
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            List<int> prime = new List<int>();

            for (int i = M; i <= N; i++)
            {
                if (isPrime(i))
                {
                    prime.Add(i);
                }
            }

            if (prime.Count == 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(prime.Sum());
                Console.WriteLine(prime.Min());
            }

        }
        static bool isPrime(int n)
        {
            if (n == 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            var sqrt = (int)Math.Sqrt(n);

            for (int i = 3; i <= sqrt; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}