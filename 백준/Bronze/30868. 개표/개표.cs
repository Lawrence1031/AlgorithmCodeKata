using System.Text;

namespace _30868
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                int plus = input / 5;
                int line = input % 5;

                if (plus > 0)
                {
                    sb.Append(string.Concat(Enumerable.Repeat("++++ ", plus)));
                }
                if (line > 0)
                {
                    sb.Append(string.Concat(Enumerable.Repeat("|", line)));
                }

                Console.WriteLine(sb.ToString());
                sb.Clear();
            }
        }
    }
}