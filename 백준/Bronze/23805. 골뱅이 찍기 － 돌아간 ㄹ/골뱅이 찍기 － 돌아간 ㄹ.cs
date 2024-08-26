using System.Text;

namespace _23805
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                sb.Append('@', N * 3);
                sb.Append(' ', N);
                sb.Append('@', N);
                sb.AppendLine();
            }

            for (int i = 0; i < 3 * N; i++)
            {
                sb.Append('@', N);
                sb.Append(' ', N);
                sb.Append('@', N);
                sb.Append(' ', N);
                sb.Append('@', N);
                sb.AppendLine();
            }

            for (int i = 0; i < N; i++)
            {
                sb.Append('@', N);
                sb.Append(' ', N);
                sb.Append('@', N * 3);
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}