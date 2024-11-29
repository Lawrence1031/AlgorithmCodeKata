namespace _17427
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine(Gx(N));
        }

        static long Gx(int n)
        {
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i * (n / i);
            }

            return sum;
        }
    }
}