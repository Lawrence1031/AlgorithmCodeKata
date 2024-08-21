using System.Text;

namespace _12517
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < T; i++)
            {
                string input = Console.ReadLine().TrimEnd();
                int len = input.Length;
                if (input[len - 1] == 'y')
                {
                    sb.AppendLine($"Case #{i + 1}: {input} is ruled by nobody.");
                }
                else if (input[len - 1] == 'a' || input[len - 1] == 'e' ||
                    input[len - 1] == 'i' || input[len - 1] == 'u' || input[len - 1] == 'o')
                {
                    sb.AppendLine($"Case #{i + 1}: {input} is ruled by a queen.");
                }
                else
                {
                    sb.AppendLine($"Case #{i + 1}: {input} is ruled by a king.");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}