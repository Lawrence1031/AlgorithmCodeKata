namespace _9461
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            List<long> Waves = new List<long>();
            Waves.Add(0);
            Waves.Add(1);
            Waves.Add(1);
            Waves.Add(1);
            Waves.Add(2);
            Waves.Add(2);

            for (int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine());
                if (Waves.Count <= N)
                {
                    for (int j = Waves.Count; j <= N; j++)
                    {
                        long next = Waves[j - 1] + Waves[j - 5];
                        Waves.Add(next);
                    }
                }

                Console.WriteLine(Waves[N]);
            }
        }
    }
}