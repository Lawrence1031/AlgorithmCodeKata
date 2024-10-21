using System.Text;

namespace _5339
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("     /~\\");
            sb.AppendLine("    ( oo|");
            sb.AppendLine("    _\\=/_");
            sb.AppendLine("   /  _  \\");
            sb.AppendLine("  //|/.\\|\\\\");
            sb.AppendLine(" ||  \\ /  ||");
            sb.AppendLine("============");
            sb.AppendLine("|          |");
            sb.AppendLine("|          |");
            sb.AppendLine("|          |");

            Console.WriteLine(sb.ToString());
        }
    }
}