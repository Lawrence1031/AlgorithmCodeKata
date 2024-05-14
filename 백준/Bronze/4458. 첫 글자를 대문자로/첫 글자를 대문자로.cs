using System.Text;

namespace _4458
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                string inputs = Console.ReadLine();
                char first = inputs[0];
                first = char.ToUpper(first);
                string str = new string(first + inputs.Substring(1, inputs.Length - 1));
                sb.AppendLine(str);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}