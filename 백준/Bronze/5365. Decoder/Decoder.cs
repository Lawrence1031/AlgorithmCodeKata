using System.Text;

namespace _5365
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            StringBuilder answer = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    answer.Append(inputs[i][0]);
                }
                else
                {
                    if (inputs[i].Length >= inputs[i - 1].Length)
                    {
                        answer.Append(inputs[i][inputs[i - 1].Length - 1]);
                    }
                    else
                    {
                        answer.Append(" ");
                    }
                }
            }

            Console.WriteLine(answer.ToString());
        }
    }
}