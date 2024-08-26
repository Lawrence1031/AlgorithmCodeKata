namespace _23972
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            long K = long.Parse(inputs[0]);
            long N = long.Parse(inputs[1]);

            if (N == 1)
            { 
                Console.WriteLine(-1);
            }
            else
            {
                long X = (K * N) / (N - 1);
                if ((K * N) % (N - 1) != 0)
                {
                    X++;
                }
                Console.WriteLine(X);
            }
        }
    }
}