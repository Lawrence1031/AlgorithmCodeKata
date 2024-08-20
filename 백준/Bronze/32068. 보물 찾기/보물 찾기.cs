using System.Text;

namespace _32068
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
                int L = int.Parse(inputs[0]);
                int R = int.Parse(inputs[1]);
                int S = int.Parse(inputs[2]);

                int left = (S - L) * 2;
                int right = (R - S - 1) * 2 + 1;
                int answer = left < right ? left : right;

                sb.AppendLine((answer + 1).ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}