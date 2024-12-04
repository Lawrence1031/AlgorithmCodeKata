using System.Numerics;

namespace _13277
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            BigInteger A = BigInteger.Parse(inputs[0]);
            BigInteger B = BigInteger.Parse(inputs[1]);

            Console.WriteLine(A * B);
        }
    }
}