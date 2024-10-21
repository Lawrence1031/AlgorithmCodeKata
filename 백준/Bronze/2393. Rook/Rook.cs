using System.Text;

namespace _2393
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("  ___  ___  ___");
            sb.AppendLine("  | |__| |__| |");
            sb.AppendLine("  |           |");
            sb.AppendLine("   \\_________/");
            sb.AppendLine("    \\_______/");
            sb.AppendLine("     |     |");
            sb.AppendLine("     |     |");
            sb.AppendLine("     |     |");
            sb.AppendLine("     |     |");
            sb.AppendLine("     |_____|");
            sb.AppendLine("  __/       \\__");
            sb.AppendLine(" /             \\");
            sb.AppendLine("/_______________\\");

            Console.WriteLine(sb.ToString());
        }
    }
}