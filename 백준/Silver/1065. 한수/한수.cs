namespace _1065
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int cnt = 0;

            for (int i = 1; i <= N; i++)
            {
                if (IsHansu(i))
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }

        static bool IsHansu(int n)
        {
            if (n < 100)
            {
                return true;
            }

            int diff = (n / 10 % 10) - (n % 10);
            while (n >= 10)
            {
                int lastDigit = n % 10;
                n /= 10;
                int nextDigit = n % 10;
                if (nextDigit - lastDigit != diff)
                {
                    return false;
                }
            }

            return true;
        }
    }
}