using System.Text;

namespace _2445
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < N; i++)
            {
                sb.Append(new string('*', i));
                sb.Append(new string(' ', 2 * (N - i)));
                sb.AppendLine(new string('*', i));
            }           
            for (int i = N; i > 0; i--)
            {
                sb.Append(new string('*', i));
                sb.Append(new string(' ', 2 * (N - i)));
                sb.AppendLine(new string('*', i));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}