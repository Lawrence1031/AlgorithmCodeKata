using System.Numerics;

namespace _1560
{
    internal class Program
    {

        static void Main(string[] args)
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());

            if (N == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(2 * N - 2);
            }


        }
    }
}