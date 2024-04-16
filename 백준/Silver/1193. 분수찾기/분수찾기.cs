namespace _1193
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            int n = 0;
            int upper = 0;
            int lower = 0;

            while (Sum(n) < X)
            {
                n++;
            }

            int coeffi = n + 1;

            if (n % 2 == 0)
            {
                upper = X - Sum(n - 1);
                lower = coeffi - upper;
            }
            else
            {
                lower = X - Sum(n - 1);
                upper = coeffi - lower;
            }

            Console.WriteLine(upper + "/" + lower);
        }

        static int Sum(int n)
        {
            return n * (n + 1) / 2;
        }
    }
}