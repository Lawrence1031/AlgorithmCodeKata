using System.Text;

namespace _12518
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
                string checkChar = input[len - 1].ToString().ToLower();
                if (checkChar == "y")
                {
                    sb.AppendLine($"Case #{i + 1}: {input} is ruled by nobody.");
                }
                else if (checkChar == "a" || checkChar == "e" ||
                    checkChar == "i" || checkChar == "u" || checkChar == "o")
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