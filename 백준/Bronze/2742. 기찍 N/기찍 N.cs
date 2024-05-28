using System.Text;

namespace _2742
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = N; i > 0; i--)
            {
                sb.AppendLine(i.ToString());
            }

            Console.WriteLine(sb);
        }
    }
}