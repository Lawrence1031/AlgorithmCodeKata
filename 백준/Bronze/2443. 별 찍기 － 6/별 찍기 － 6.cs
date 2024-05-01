using System.Text;

namespace _2443
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = N; i > 0; i--)
            {
                sb.Append(new string(' ', N - i));
                sb.AppendLine(new string('*', 2 * i - 1));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}