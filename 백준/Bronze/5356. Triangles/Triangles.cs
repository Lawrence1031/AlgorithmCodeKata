using System.Text;

namespace _5356
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int cnt = int.Parse(inputs[0]);
                char startChar = inputs[1][0];

                for (int j = 0; j < cnt; j++)
                {
                    if ((char)(startChar + j) > 'Z')
                    {
                        sb.AppendLine(new string((char)(startChar + j - 26), j + 1));
                    }
                    else
                    {
                        sb.AppendLine(new string((char)(startChar + j), j + 1));
                    }
                }
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}