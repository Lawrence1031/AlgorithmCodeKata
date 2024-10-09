using System.Text;

namespace _9226
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<char> chars = new HashSet<char>("aeiou");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "#")
                {
                    return;
                }

                StringBuilder sb = new StringBuilder();
                int idx = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    if (chars.Contains(input[i]))
                    {
                        idx = i;
                        break;
                    }
                }

                sb.Append(input, idx, input.Length - idx);
                sb.Append(input, 0, idx);
                sb.Append("ay");

                Console.WriteLine(sb.ToString());
            }
        }
    }
}