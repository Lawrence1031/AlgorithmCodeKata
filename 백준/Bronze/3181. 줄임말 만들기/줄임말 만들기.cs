using System.Text;

namespace _3181
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] iranai = { "i", "pa", "te", "ni", "niti", "a", "ali", "nego", "no", "ili" };
            string[] inputs = input.Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < inputs.Length; i++)
            {
                if (i == 0 || Array.IndexOf(iranai, inputs[i]) == -1)
                {
                    sb.Append(inputs[i].Substring(0, 1).ToUpper());
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}