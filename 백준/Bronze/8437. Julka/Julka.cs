using System.Numerics;

namespace _8437
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger other = BigInteger.Parse(Console.ReadLine());

            BigInteger answer = (n - other) / 2;

            Console.WriteLine(answer + other);
            Console.WriteLine(answer);
        }
    }
}