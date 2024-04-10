namespace _5525
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();

            int cnt = 0;
            int pattern = 0;

            for (int i = 1; i < M - 1; i++)
            {
                if (S[i - 1] == 'I' && S[i] == 'O' && S[i + 1] == 'I')
                {
                    pattern++;
                    if (pattern == N)
                    {
                        cnt++;
                        pattern--;
                    }
                    i++;
                }
                else
                {
                    pattern = 0;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}