using System.Numerics;

namespace _2417
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(binarySearch(number));
        }

        static BigInteger binarySearch(BigInteger n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            BigInteger left = 0;
            BigInteger right = n;
            BigInteger ans = 0;

            while (left <= right)
            {
                BigInteger mid = left + (right - left) / 2;
                BigInteger midmid = mid * mid;

                if (midmid == n)
                {
                    return mid;
                }
                else if (midmid < n)
                {
                    left = mid + 1;
                    ans = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return ans * ans == n ? ans : ans + 1;
        }
    }
}