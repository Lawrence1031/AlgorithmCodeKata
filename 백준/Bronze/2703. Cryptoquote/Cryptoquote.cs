using System.Text;

namespace _2703
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string input = Console.ReadLine();
                string code = Console.ReadLine();
                StringBuilder answer = new StringBuilder();

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == ' ')
                    {
                        answer.Append(' ');
                    }
                    else
                    {
                        answer.Append(code[input[j] - 'A']);
                    }
                }

                Console.WriteLine(answer.ToString());
            }
        }
    }
}