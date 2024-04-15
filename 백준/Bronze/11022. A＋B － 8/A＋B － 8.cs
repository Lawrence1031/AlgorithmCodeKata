using System.Text;

namespace _11022
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
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                sb.AppendLine("Case #" + i + ": " + a + " + " + b + " = " + (a + b));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}