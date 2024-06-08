using System.Text;

namespace _11945
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            char[,] arr = new char[N, M];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < M; j++)
                {
                    arr[i, j] = input[j];
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M / 2; j++)
                {
                    char tmp = arr[i, j];
                    arr[i, j] = arr[i, M - j - 1];
                    arr[i, M - j - 1] = tmp;
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    sb.Append(arr[i, j]);
                }
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}