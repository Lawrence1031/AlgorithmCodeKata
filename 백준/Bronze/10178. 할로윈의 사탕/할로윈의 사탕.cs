using System.Text;

namespace _10178
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < T; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int candies = int.Parse(inputs[0]);
                int brothers = int.Parse(inputs[1]);
                sb.AppendLine($"You get {candies / brothers} piece(s) and your dad gets {candies % brothers} piece(s).");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}