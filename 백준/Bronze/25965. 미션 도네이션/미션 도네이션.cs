using System.Text;

namespace _25965
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int games = 0; games < N; games++)
            {
                int M = int.Parse(Console.ReadLine());
                int[][] missions = new int[M][];

                for (int i = 0; i < M; i++)
                {
                    missions[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                }

                int[] KDA = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                long total = 0;

                for (int i = 0; i < M; i++)
                {
                    long reward = (long)missions[i][0] * KDA[0] - (long)missions[i][1] * KDA[1]
                                  + (long)missions[i][2] * KDA[2];

                    if (reward > 0)
                    {
                        total += reward;
                    }
                }

                sb.AppendLine(total.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}