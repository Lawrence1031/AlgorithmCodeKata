using System.Text;

namespace _10419
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < T; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sb.AppendLine(FindTime(n));
            }

            Console.WriteLine(sb.ToString());
        }

        static string FindTime(int n)
        {
            int time = 0;

            for (int i = 1; i * i + i <= n; i++)
            {
                time = i;
            }

            return time.ToString();
        }
    }
}