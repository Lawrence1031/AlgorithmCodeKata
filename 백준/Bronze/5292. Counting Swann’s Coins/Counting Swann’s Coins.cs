using System.Text;

namespace _5292
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                {
                    sb.AppendLine("DeadMan");
                }
                else if (i % 3 == 0)
                {
                    sb.AppendLine("Dead");
                }
                else if (i % 5 == 0)
                {
                    sb.AppendLine("Man");
                }
                else
                {
                    sb.Append(i + " ");
                }                
            }

            Console.WriteLine(sb.ToString());
        }
    }
}