using System.Text;

namespace _2845
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            StringBuilder sb = new StringBuilder();

            int L = int.Parse(inputs[0]);
            int P = int.Parse(inputs[1]);

            inputs = Console.ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
            {
                sb.Append(int.Parse(inputs[i]) - (L * P) + " ");
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}