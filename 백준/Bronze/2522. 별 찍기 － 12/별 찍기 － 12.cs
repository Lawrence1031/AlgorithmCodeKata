using System.Text;

namespace _2522
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                sb.Append(new string(' ', N - i - 1));
                sb.AppendLine(new string('*', i + 1));
            }
            for (int i = N - 1; i > 0; i--)
            {
                sb.Append(new string(' ', N - i));
                sb.AppendLine(new string('*', i));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}