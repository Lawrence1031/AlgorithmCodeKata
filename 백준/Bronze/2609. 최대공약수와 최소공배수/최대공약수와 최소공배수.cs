namespace _2609
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int N = Convert.ToInt32(s.Split(' ')[0]);
            int M = Convert.ToInt32(s.Split(' ')[1]);

            int ansGCD = GCD(N, M);
            int ansLCM = LCM(N, M, ansGCD);

            Console.WriteLine(ansGCD);
            Console.WriteLine(ansLCM);
        }

        static int GCD(int N, int M)
        {
            int GCD = 1;
            for (int i = Math.Min(N, M); i > 1; i--)
            {
                if (N % i == 0 && M % i == 0)
                {
                    GCD = i;
                    N = N / i;
                    M = M / i;
                }
            }

            return GCD;
        }

        static int LCM(int N, int M, int GCD)
        {
            int LCM = N * M / GCD;

            return LCM;
        }
    }
}