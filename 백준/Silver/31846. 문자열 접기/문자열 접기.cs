namespace _31846
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();
            int Q = int.Parse(Console.ReadLine());

            List<Tuple<int, int>> queries = new List<Tuple<int, int>>();
            for (int test = 0; test < Q; test++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int l = int.Parse(inputs[0]);
                int r = int.Parse(inputs[1]);
                queries.Add(new Tuple<int, int>(l, r));
            }

            foreach (var query in queries)
            {
                int l = query.Item1 - 1;
                int r = query.Item2 - 1;
                int maxScore = 0;

                for (int mid = l; mid < r; mid++)
                {
                    int score = 0;
                    int left = mid;
                    int right = mid + 1;

                    while (left >= l && right <= r)
                    {
                        if (S[left] == S[right])
                        {
                            score++;
                        }
                        left--;
                        right++;
                    }

                    if (score > maxScore)
                    {
                        maxScore = score;
                    }
                }

                Console.WriteLine(maxScore);
            }
        }
    }
}