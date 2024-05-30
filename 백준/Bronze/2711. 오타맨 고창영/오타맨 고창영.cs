using System.Text;

namespace _2711
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int n = int.Parse(inputs[0]);
                string words = inputs[1];

                StringBuilder sb = new StringBuilder();
                sb.Append(words);
                sb.Remove(n - 1, 1);

                Console.WriteLine(sb.ToString());
            }
        }
    }
}