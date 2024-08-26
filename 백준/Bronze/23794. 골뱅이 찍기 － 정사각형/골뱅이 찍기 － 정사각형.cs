using System.Text;

namespace _23794
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('@', N + 2));
            for (int i = 0; i < N; i++)
            {
                sb.Append('@');
                sb.Append(' ', N);
                sb.Append('@');
                sb.AppendLine();
            }
            sb.AppendLine(new string('@', N + 2));

            Console.WriteLine(sb.ToString());
        }
    }
}