using System.Text;

namespace _11021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= T; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int result = int.Parse(inputs[0]) + int.Parse(inputs[1]);
                sb.AppendLine("Case #" + i + ": " + result);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}