using System.Numerics;

namespace _2408
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> tokens = new List<string>();

            for (int i = 0; i < 2 * n - 1; i++)
            {
                tokens.Add(Console.ReadLine());
            }

            List<string> firstTokens = MultipleDivision(tokens);

            BigInteger result = PlusMinus(firstTokens);

            Console.WriteLine(result);
        }

        static List<string> MultipleDivision(List<string> tokens)
        {
            List<string> firstTokens = new List<string>();
            int i = 0;

            while (i < tokens.Count)
            {
                if (tokens[i] == "*" || tokens[i] == "/")
                {
                    BigInteger prev = BigInteger.Parse(firstTokens[firstTokens.Count - 1]);
                    BigInteger next = BigInteger.Parse(tokens[i + 1]);
                    BigInteger result = tokens[i] == "*" ? prev * next : DivideAndFloor(prev, next);
                    firstTokens[firstTokens.Count - 1] = result.ToString();
                    i += 2;
                }
                else
                {
                    firstTokens.Add(tokens[i]);
                    i++;
                }
            }

            return firstTokens;
        }

        static BigInteger PlusMinus(List<string> tokens)
        {
            BigInteger result = BigInteger.Parse(tokens[0]);
            for (int i = 1; i < tokens.Count; i += 2)
            {
                string operation = tokens[i];
                BigInteger next = BigInteger.Parse(tokens[i + 1]);

                result = operation == "+" ? result + next : result - next;
            }

            return result;
        }

        static BigInteger DivideAndFloor(BigInteger a, BigInteger b)
        {
            if (a * b < 0)
            {
                return (a / b) - (a % b == 0 ? 0 : 1);
            }
            else
            {
                return a / b;
            }
        }
    }
}