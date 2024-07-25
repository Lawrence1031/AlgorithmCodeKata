namespace _28432
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] words = new string[N];
            int cnt = -1;
            for (int i = 0; i < N; i++)
            {
                words[i] = Console.ReadLine();
                if (words[i] == "?")
                {
                    cnt = i;
                }
            }

            int n = int.Parse(Console.ReadLine());
            string[] candidates = new string[n];
            for (int i = 0; i < n; i++)
            {
                candidates[i] = Console.ReadLine();
            }

            char up = cnt > 0 ? words[cnt - 1].Last() : '\0';
            char down = cnt < N - 1 ? words[cnt + 1].First() : '\0';

            string answer = "";
            foreach (string candidate in candidates)
            {
                if ((up == '\0' || candidate[0] == up) && (down == '\0' || candidate.Last() == down))
                {
                    bool isDuplicate = false;
                    for (int i = 0; i < N; i++)
                    {
                        if (i != cnt && words[i] == candidate)
                        {
                            isDuplicate = true;
                            break;
                        }
                    }

                    if (!isDuplicate)
                    {
                        answer = candidate;
                        break;
                    }
                }
            }

            Console.WriteLine(answer);
        }
    }
}