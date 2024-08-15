namespace _16175
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int test = 0; test < T; test++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int N = int.Parse(inputs[0]);
                int M = int.Parse(inputs[1]);
                int[] candidates = new int[N];
                for (int i = 0; i < M; i++)
                {
                    string[] votes = Console.ReadLine().Split(' ');
                    for (int j = 0; j < N; j++)
                    {
                        candidates[j] += int.Parse(votes[j]);
                    }
                }

                int maxIdx = candidates.Select((value, index) => new { value, index })
                                       .OrderByDescending(x => x.value)
                                       .First()
                                       .index;

                Console.WriteLine(maxIdx + 1);
            }
        }
    }
}