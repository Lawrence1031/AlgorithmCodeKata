using System.Text;

namespace _2442
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
                sb.AppendLine(new string('*', 2 * i + 1));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}