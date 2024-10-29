using System.Text;

namespace _3062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                int n = int.Parse(input);
                int reverseN = ReverseInput(input);
                int sum = n + reverseN;

                sb.AppendLine(IsPalin(sum.ToString()) ? "YES" : "NO");
            }

            Console.WriteLine(sb.ToString());
        }

        static int ReverseInput(string input)
        {
            StringBuilder numSb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                numSb.Append(input[input.Length - i - 1]);
            }

            return int.Parse(numSb.ToString());
        }

        static bool IsPalin(string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}