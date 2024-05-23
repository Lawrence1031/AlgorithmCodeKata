namespace _1417
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int dasom = int.Parse(Console.ReadLine());

            if (N == 1)
            {
                Console.WriteLine(0);
                return;
            }

            int[] candidates = new int[N - 1];
            for (int i = 0; i < N - 1; i++)
            {
                candidates[i] = int.Parse(Console.ReadLine());
            }

            int maxVote = candidates.Max();
            int cnt = 0;

            if (dasom > maxVote)
            {
                Console.WriteLine(0);
                return;
            }
            else
            {
                while (dasom <= maxVote)
                {
                    dasom++;
                    candidates[Array.IndexOf(candidates, maxVote)]--;
                    maxVote = candidates.Max();
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}