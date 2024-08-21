namespace _17253
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());

            Console.WriteLine(isTrit(N) ? "YES" : "NO");
        }

        static bool isTrit(long n)
        {
            if (n == 0) return false;

            while (n > 0)
            {
                long remainder = n % 3;
                if (remainder > 1)
                {
                    return false;
                }
                n /= 3;
            }

            return true;
        }
    }
}