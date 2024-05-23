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

            int cnt = 0;

            while (true)
            {
                Array.Sort(candidates);
                Array.Reverse(candidates);

                if (dasom > candidates[0])
                {
                    break;
                }

                dasom++;
                candidates[0]--;
                cnt++;
            }

            Console.WriteLine(cnt);
        }
    }
}