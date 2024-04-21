namespace _27433
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(N));
        }

        static long Factorial(long n)
        {
            long fact = 1;
            if (n == 0) return 1;

            while (n > 1)
            {
                fact *= n;
                n--;
            }

            return fact;
        }
    }
}