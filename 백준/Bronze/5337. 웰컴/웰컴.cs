using System.Text;

namespace _5337
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(".  .   .");
            sb.AppendLine("|  | _ | _. _ ._ _  _");
            sb.AppendLine("|/\\|(/.|(_.(_)[ | )(/.");

            Console.WriteLine(sb.ToString());
        }
    }
}