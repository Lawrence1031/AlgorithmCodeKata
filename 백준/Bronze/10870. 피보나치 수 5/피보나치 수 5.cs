namespace _10870
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // F(0) = 0, F(1) = 1, F(2) = 1
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(N));
        }

        static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}