using System.Text;

namespace _31134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int test = 0; test < T; test++)
            {
                long x = long.Parse(Console.ReadLine());
                long games = 2 * x - 1;
                sb.AppendLine(games.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}