using System.Text;

namespace _11660
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int N = int.Parse(input.Split(' ')[0]);
            int M = int.Parse(input.Split(' ')[1]);
            int[,] arr = new int[N + 1, N + 1];
            int[,] sum = new int[N + 1, N + 1];
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= N; i++)
            {
                input = Console.ReadLine();
                var numbers = input.Split(' ').Select(int.Parse).ToArray();

                for (int j = 1; j <= N; j++)
                {
                    arr[i, j] = numbers[j - 1];
                    sum[i, j] = arr[i, j] + sum[i - 1, j] + sum[i, j - 1] - sum[i - 1, j - 1];
                }
            }

            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine();
                var points = input.Split(' ').Select(int.Parse).ToArray();
                int x1 = points[0];
                int y1 = points[1];
                int x2 = points[2];
                int y2 = points[3];

                int result = sum[x2, y2] - sum[x2, y1 - 1] - sum[x1 - 1, y2] + sum[x1 - 1, y1 - 1];

                sb.AppendLine(result.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}