using System.Text;

namespace _1929
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int M = int.Parse(input.Split(' ')[0]);
            int N = int.Parse(input.Split(' ')[1]);
            StringBuilder sb = new StringBuilder();

            for (int i = M; i <= N; i++)
            {
                if (IsPrime(i))
                {
                    sb.AppendLine(i.ToString());
                }
            }
            Console.WriteLine(sb.ToString());
        }

        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            int sqrt = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 3; i <= sqrt; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}