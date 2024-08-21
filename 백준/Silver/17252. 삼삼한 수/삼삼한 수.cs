namespace _17252
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine(isTrit(N) ? "YES" : "NO");
        }

        static bool isTrit(int n)
        {
            if (n == 0) return false;

            while (n > 0)
            {
                int remainder = n % 3;
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
