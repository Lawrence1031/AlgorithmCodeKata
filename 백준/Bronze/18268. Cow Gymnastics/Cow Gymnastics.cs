namespace _18268
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int K = int.Parse(inputs[0]);
            int N = int.Parse(inputs[1]);

            int[][] rankings = new int[K][];
            for (int i = 0; i < K; i++)
            {
                rankings[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            }

            int pairs = 0;

            for (int cow1 = 1; cow1 <= N; cow1++)
            {
                for (int cow2 = cow1 + 1; cow2 <= N; cow2++)
                {
                    bool cow1AlwaysBefore = true;
                    bool cow2AlwaysBefore = true;

                    for (int i = 0; i < K; i++)
                    {
                        int cow1Rank = Array.IndexOf(rankings[i], cow1);
                        int cow2Rank = Array.IndexOf(rankings[i], cow2);

                        if (cow1Rank > cow2Rank)
                        {
                            cow1AlwaysBefore = false;
                        }
                        if (cow1Rank < cow2Rank)
                        {
                            cow2AlwaysBefore = false;
                        }

                        if (!cow1AlwaysBefore && !cow2AlwaysBefore)
                        {
                            break;
                        }
                    }

                    if (cow1AlwaysBefore || cow2AlwaysBefore)
                    {
                        pairs++;
                    }
                }
            }

            Console.WriteLine(pairs);
        }
    }
}