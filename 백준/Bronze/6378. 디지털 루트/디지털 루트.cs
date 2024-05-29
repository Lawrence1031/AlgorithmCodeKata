using System.Numerics;
using System.Text;

namespace _6378
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "0")
                {
                    Console.WriteLine(sb);
                    return;
                }

                BigInteger n = BigInteger.Parse(input);
                int result = AddDigit(n);

                sb.AppendLine(result.ToString());
            }
        }

        static int AddDigit(BigInteger n)
        {
            while (n >= 10)
            {
                BigInteger sum = 0;
                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                n = sum;
            }

            return (int)n;
        }
    }
}