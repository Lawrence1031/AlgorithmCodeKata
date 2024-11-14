using System.Text;

namespace _24084
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N - 1; i++)
            {
                char now = S[i];
                char next = S[i + 1];

                if (next == 'J')
                {
                    sb.AppendLine(now.ToString());
                }
            }
            
            Console.WriteLine(sb);
        }
    }
}