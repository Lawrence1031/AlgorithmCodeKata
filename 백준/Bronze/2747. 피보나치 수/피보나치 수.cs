namespace _2747
{
    internal class Program
    {
        static int[] fibo = new int[46];

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(n));
        }

        static int Fibonacci(int n)
        {
            fibo[1] = 1;
            fibo[2] = 1;

            for (int i = 3; i <= n; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }

            return fibo[n];
        }
    }
}