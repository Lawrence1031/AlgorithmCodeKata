using System.Text;

namespace _5724
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == 0)
                {
                    Console.WriteLine(sb.ToString());
                    return;
                }

                int answer = 0;

                for (int i = 1; i <= n; i++)
                {
                    answer += i * i;
                }

                sb.AppendLine(answer.ToString());
            }
        }
    }
}