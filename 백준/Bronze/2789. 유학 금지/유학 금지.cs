using System.Text;

namespace _2789
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                if (RemoveChars(c) != ' ')
                {
                    sb.Append(RemoveChars(c));
                }
            }

            Console.WriteLine(sb);
        }

        static char RemoveChars(char c)
        {
            // CAMBRIDGE
            if (c == 'C' || c == 'A' || c == 'M' || c == 'B' ||
                c == 'R' || c == 'I' || c == 'D' || c == 'G' || c == 'E')
            {
                return ' ';
            }
            else
            {
                return c;
            }
        }
    }
}