namespace baekjoon2501
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int S = inputs[0];
            int N = inputs[1];
            int M = inputs[2];

            int maxLen = S;
            int now = 0;

            for (int i = 0; i < N + M; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    now++;
                }
                else
                {
                    now--;
                }

                if (now > maxLen)
                {
                    maxLen *= 2;
                }
            }

            Console.WriteLine(maxLen);
        }
    }
}