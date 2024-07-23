using System.Numerics;

namespace _10757
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            BigInteger a = BigInteger.Parse(inputs[0]);
            BigInteger b = BigInteger.Parse(inputs[1]);
            Console.WriteLine(a + b);
        }
    }
}