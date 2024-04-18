namespace _4948
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == 0)
                {
                    break;
                }

                Console.WriteLine(PrimeCnt(n));
            }
        }

        static int PrimeCnt(int n)
        {
            int cnt = 0;

            for (int i = n + 1; i <= 2 * n; i++)
            {
                if (IsPrime(i))
                {
                    cnt++;
                }
            }

            return cnt;
        }

        static bool IsPrime(int n)
        {
            if (n == 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}