using System.Text;

namespace _5357
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                StringBuilder sb = new StringBuilder();

                char nowChar = input[0];
                sb.Append(nowChar);
                for (int j = 1; j < input.Length; j++)
                {
                    if (nowChar != input[j])
                    {
                        nowChar = input[j];
                        sb.Append(nowChar);
                    }
                }

                Console.WriteLine(sb.ToString());
            }
        }
    }
}