using System.Text;

namespace _5524
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                sb.AppendLine(input.ToLower());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}