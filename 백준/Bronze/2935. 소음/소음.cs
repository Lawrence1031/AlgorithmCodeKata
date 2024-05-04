using System.Numerics;

namespace _2935
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger A = BigInteger.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            BigInteger B = BigInteger.Parse(Console.ReadLine());

            if (oper == "+")
            {
                Console.WriteLine(A + B);
            }
            else
            {
                Console.WriteLine(A * B);
            }
        }
    }
}