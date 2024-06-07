namespace _2546
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                Console.ReadLine();

                string[] inputs = Console.ReadLine().Split(' ');
                int N = int.Parse(inputs[0]);
                int M = int.Parse(inputs[1]);
                long[] CIQ = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                long[] ecoIQ = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

                long CIQSum = CIQ.Sum();
                long ecoIQSum = ecoIQ.Sum();

                double CIQAver = (double)CIQSum / N;
                double ecoIQAver = (double)ecoIQSum / M;

                int cnt = 0;

                for (int j = 0; j < N; j++)
                {
                    double newCIQAver = (double)(CIQSum - CIQ[j]) / (N - 1);
                    double newEcoIQAver = (double)(ecoIQSum + CIQ[j]) / (M + 1);

                    if (newCIQAver > CIQAver && newEcoIQAver > ecoIQAver)
                    {
                        cnt++;
                    }
                }

                Console.WriteLine(cnt);
            }
        }
    }
}