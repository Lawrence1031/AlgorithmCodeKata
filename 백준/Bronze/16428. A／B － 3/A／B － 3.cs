using System.Numerics;

namespace _16428
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            BigInteger A = BigInteger.Parse(inputs[0]);
            BigInteger B = BigInteger.Parse(inputs[1]);

            BigInteger C = A / B;
            BigInteger D = A % B;

            if (D < 0)
            {
                if (B > 0)
                {
                    C--;
                    D += B;
                }
                else
                {
                    C++;
                    D -= B;
                }
            }

            Console.WriteLine(C);
            Console.WriteLine(D);
        }
    }
}