using System.Text;

namespace _2954
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length;)
            {
                if (CheckAeiou(input, i))
                {
                    sb.Append(input[i]);
                    i += 3;
                }
                else
                {
                    sb.Append(input[i]);
                    i++;
                }
            }

            Console.WriteLine(sb.ToString());
        }

        static bool CheckAeiou(string input, int idx)
        {
            char[] aeiou = { 'a', 'e', 'i', 'o', 'u' };
            if (idx + 2 >= input.Length) return false;

            return Array.Exists(aeiou, x => x == input[idx] &&
                   input[idx + 1] == 'p' && input[idx + 2] == input[idx]);
        }
    }
}