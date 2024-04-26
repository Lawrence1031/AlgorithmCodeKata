using System.Numerics;

namespace _1271
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            BigInteger n = BigInteger.Parse(input.Split(' ')[0]);
            BigInteger m = BigInteger.Parse(input.Split(' ')[1]);

            Console.WriteLine(n / m);
            Console.WriteLine(n % m);
        }
    }
}