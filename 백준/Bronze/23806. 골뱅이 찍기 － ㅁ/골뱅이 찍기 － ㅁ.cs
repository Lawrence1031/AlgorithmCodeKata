using System.Text;

namespace _23806
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                sb.AppendLine(new string('@', 5 * N));
            }

            for (int i = 0; i < 3 * N; i++)
            {
                sb.Append(new string('@', N));
                sb.Append(new string(' ', 3 * N));
                sb.AppendLine(new string('@', N));
            }

            for (int i = 0; i < N; i++)
            {
                sb.AppendLine(new string('@', 5 * N));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}