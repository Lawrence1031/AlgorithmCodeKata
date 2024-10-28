using System.Numerics;

namespace _2061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            BigInteger K = BigInteger.Parse(inputs[0]);
            int L = int.Parse(inputs[1]);

            for (int i = 2; i < L; i++)
            {
                if (K % i == 0)
                {
                    Console.WriteLine($"BAD {i}");
                    return;
                }
            }

            Console.WriteLine("GOOD");
        }
    }
}