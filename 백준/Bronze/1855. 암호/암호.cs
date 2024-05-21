using System.Text;

namespace _1855
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int len = input.Length / K;
            char[,] alp = new char[len, K];

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    if (i % 2 == 0)
                    {
                        alp[i, j] = input[K * i + j];
                    }
                    else
                    {
                        alp[i, j] = input[K * (i + 1) - j - 1];
                    }
                }
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    sb.Append(alp[j, i]);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}