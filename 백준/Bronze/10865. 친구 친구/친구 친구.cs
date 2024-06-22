using System.Text;

namespace _10865
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int[] friends = new int[N + 1];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < M; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);

                friends[a]++;
                friends[b]++;
            }

            for (int i = 1; i <= N; i++)
            {
                sb.AppendLine(friends[i].ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}