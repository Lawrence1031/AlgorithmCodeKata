namespace _4134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                long n = long.Parse(Console.ReadLine());
                Console.WriteLine(NextPrime(n));
            }
        }
        static long NextPrime(long n)
        {
            if (IsPrime(n))
            {
                return n;
            }
            else
            {
                return NextPrime(n + 1);
            }
        }
        static bool IsPrime(long n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (long i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}