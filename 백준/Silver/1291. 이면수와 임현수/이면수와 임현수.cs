using System;

namespace _1291
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            bool isImyeon = IsImyeon(N);
            bool isImhyeon = IsImhyeon(N);

            if (isImyeon && isImhyeon)
            {
                Console.WriteLine(4);
            }
            else if (isImyeon)
            {
                Console.WriteLine(1);
            }
            else if (isImhyeon)
            {
                Console.WriteLine(2);
            }
            else
            {
                Console.WriteLine(3);
            }
        }

        static bool IsImyeon(int N)
        {
            return IsPerfectNumber(N) && IsDigitSumOdd(N);
        }

        static bool IsPerfectNumber(int N)
        {
            if (N > 3 && N != 5) return true;

            return false;
        }

        static bool IsDigitSumOdd(int N)
        {
            int sum = 0;
            while (N > 0)
            {
                sum += N % 10;
                N /= 10;
            }

            return sum % 2 != 0;
        }

        static bool IsImhyeon(int N)
        {
            if (N == 2 || N == 4)
            {
                return true;
            }

            if (N < 2)
            {
                return false;
            }

            var primeFactors = GetPrimeFactors(N);
            return primeFactors.Count > 1 && primeFactors.Distinct().Count() % 2 == 0;
        }

        static List<int> GetPrimeFactors(int N)
        {
            List<int> factors = new List<int>();
            for (int i = 2; i * i <= N; i++)
            {
                while (N % i == 0)
                {
                    factors.Add(i);
                    N /= i;
                }
            }

            if (N > 1)
            {
                factors.Add(N);
            }

            return factors;
        }
    }
}