using System.Text;

namespace _2444
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int goal = 2 * N - 1;
            int cnt = 1;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                int star = 2 * i + 1;
                int blank = (goal - star) / 2;

                sb.Append(' ', blank);
                sb.Append('*', star);
                sb.AppendLine();
            }
            for (int i = N; i > 1; i--)
            {
                int star = 2 * i - 3;
                int blank = (goal - star) / 2;

                sb.Append(' ', blank);
                sb.Append('*', star);
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}