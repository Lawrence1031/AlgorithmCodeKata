using System.Text;

namespace _5598
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char newChar = (char)(input[i] - 3);

                if (newChar >= 'A')
                {
                    sb.Append(newChar);
                }
                else
                {
                    sb.Append((char)(newChar + 26));
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}