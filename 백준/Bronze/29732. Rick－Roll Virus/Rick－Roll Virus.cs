namespace _29732
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int K = int.Parse(inputs[2]);
            string input = Console.ReadLine();
            char[] virus = new char[N];
            for (int i = 0; i < input.Length; i++)
            {
                virus[i] = input[i];
            }

            char[] nextDayVirus = new char[N];
            Array.Copy(virus, nextDayVirus, N);

            for (int i = 0; i < N; i++)
            {
                if (virus[i] == 'R')
                {
                    int start = Math.Max(0, i - K);
                    int end = Math.Min(N - 1, i + K);
                    for (int j = start; j <= end; j++)
                    {
                        nextDayVirus[j] = 'R';
                    }
                }
            }

            int virusCnt = 0;
            foreach (char c in nextDayVirus)
            {
                if (c == 'R')
                    virusCnt++;
            }

            Console.WriteLine(virusCnt > M ? "No" : "Yes");
        }
    }
}