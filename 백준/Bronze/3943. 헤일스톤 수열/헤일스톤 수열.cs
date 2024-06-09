using System.Text;

namespace _3943
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Dictionary<int, int> memo = new Dictionary<int, int>();

            for (int i = 0; i < T; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int maxNumber = FindMax(n, memo);
                sb.AppendLine(maxNumber.ToString());
            }

            Console.WriteLine(sb.ToString());
        }

        static int FindMax(int n, Dictionary<int, int> memo)
        {
            int original = n;
            int maxNumber = n;

            while (n != 1 && !IsPowerOfTwo(n))
            {
                if (memo.ContainsKey(n))
                {
                    maxNumber = Math.Max(maxNumber, memo[n]);
                    break;
                }

                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = n * 3 + 1;
                }

                maxNumber = Math.Max(maxNumber, n);
            }

            memo[original] = maxNumber;
            return maxNumber;
        }

        static bool IsPowerOfTwo(int n)
        {
            return (n > 0) && (n & (n - 1)) == 0;
        }
    }
}