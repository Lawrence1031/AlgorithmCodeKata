namespace _24416
{
    internal class Program
    {
        static int callCnt = 0;
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            fib(N);

            Console.Write(callCnt + 1);
            Console.WriteLine(" " + (N - 2));
        }

        static int fib(int n)
        {
            if (n == 1 || n == 2) return 1;

            callCnt++;

            return fib(n - 1) + fib(n - 2);
        }

        static int fibonacci(int n)
        {
            int[] f = new int[n + 1];
            f[1] = 1;
            f[2] = 1;

            for (int i = 3; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }

            return f[n];
        }
    }
}