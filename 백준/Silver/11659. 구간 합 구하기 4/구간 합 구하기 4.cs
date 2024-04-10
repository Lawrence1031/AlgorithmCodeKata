using System.Text;

namespace _11659
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int N = int.Parse(input.Split(' ')[0]);
            int M = int.Parse(input.Split(' ')[1]);
            StringBuilder sb = new StringBuilder();

            int[] arr = new int[N];
            long[] sum = new long[N + 1];
            sum[0] = 0;

            input = Console.ReadLine();
            string[] inputs = input.Split(' ');

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(inputs[i]);
                sum[i + 1] = sum[i] + arr[i];
            }

            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine();
                int start = int.Parse(input.Split(' ')[0]);
                int end = int.Parse(input.Split(' ')[1]);

                long answer = sum[end] - sum[start - 1];

                sb.AppendLine(answer.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}