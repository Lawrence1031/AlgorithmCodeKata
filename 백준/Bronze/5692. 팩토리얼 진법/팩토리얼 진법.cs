using System.Text;

namespace _5692
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] factorials = new int[6];
            factorials[0] = 1;
            for (int i = 1; i < 6; i++)
            {
                factorials[i] = factorials[i - 1] * i;
            }

            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "0")
                {
                    Console.WriteLine(sb.ToString());
                    return;
                }

                int answer = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    answer += (input[i] - '0') * factorials[input.Length - i];
                }

                sb.AppendLine(answer.ToString());
            }
        }
    }
}