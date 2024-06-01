namespace _1166
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] inputs = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double N = inputs[0];
            double L = inputs[1];
            double W = inputs[2];
            double H = inputs[3];

            double low = 0;
            double high = Math.Min(L, Math.Min(W, H));
            double mid = 0;
            int cnt = 0;

            while (high - low > 1e-9)
            {
                mid = (low + high) / 2;
                if (CanFit(mid, N, L, W, H))
                {
                    low = mid;
                }
                else
                {
                    high = mid;
                }

                cnt++;

                if (cnt > 1000000)
                    break;
            }

            Console.WriteLine(low);
        }

        static bool CanFit(double side, double N, double L, double W, double H)
        {
            long countL = (long)(L / side);
            long countW = (long)(W / side);
            long countH = (long)(H / side);

            return (double)countL * countW * countH >= N;
        }
    }
}