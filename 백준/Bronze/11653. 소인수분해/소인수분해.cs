namespace _11653
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 2; i * i <= N; i++)
            {
                while (N % i == 0)
                {
                    Console.WriteLine(i);
                    N /= i;
                }
            }

            if (N > 1)
            {
                Console.WriteLine(N);
            }
        }
    }
}