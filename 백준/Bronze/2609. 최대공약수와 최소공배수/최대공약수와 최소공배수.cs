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
            if (M == 0)
            {
                return N;
            }
            return GCD(M, N % M);
        }

        static int LCM(int N, int M, int GCD)
        {
            return N * M / GCD;
        }
    }
}