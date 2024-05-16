using System.Numerics;

namespace _2052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger binary = BigInteger.Pow(2, n);

            string lowerNum = "1";
            string answer = Divide(lowerNum, binary, n);

            Console.WriteLine(answer);
        }

        static string Divide(string lowerNum, BigInteger bigInteger, int n)
        {
            BigInteger num = BigInteger.Parse(lowerNum);
            BigInteger remainder;
            string result = "";
            int precision = n * 3;

            for (int i = 0; i < precision; i++)
            {
                result += (num / bigInteger).ToString();
                num = BigInteger.DivRem(num, bigInteger, out remainder);
                num = remainder;
                num *= 10;

                if (num == 0) break;
                if (i == 0) result += ".";
            }

            return result.TrimEnd('0').TrimEnd('.');
        }
    }
}