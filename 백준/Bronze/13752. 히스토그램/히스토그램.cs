using System.Text;

namespace _13752
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sb.AppendLine(new string('=', num));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}