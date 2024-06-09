namespace _2748
{
    internal class Program
    {
        static Dictionary<int, long> Fibo = new Dictionary<int, long>();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(fibonacci(n));
        }

        static long fibonacci(int n)
        {
            Fibo[1] = 1;
            Fibo[2] = 1;
            int cnt = 3;

            while (!Fibo.ContainsKey(n))
            {
                Fibo[cnt] = Fibo[cnt - 1] + Fibo[cnt - 2];
                cnt++;
            }

            return Fibo[n];
        }
    }
}