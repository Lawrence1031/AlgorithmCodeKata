using System.Text;

namespace _1975
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < T; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sb.AppendLine(ZeroCnt(n).ToString());
            }

            Console.WriteLine(sb);
        }

        static int ZeroCnt(int n)
        {
            int cnt = 0;

            for (int i = 2; n >= i; i++)
            {
                int zeroCnt = 0;
                int tmp = n;

                while (tmp % i == 0)
                {
                    zeroCnt++;
                    tmp /= i;
                }

                cnt += zeroCnt;
            }

            return cnt;
        }
    }
}