using System.Text;

namespace _31656
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            char beforeChar = input[0];
            sb.Append(beforeChar);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != beforeChar)
                {
                    beforeChar = input[i];
                    sb.Append(beforeChar);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}