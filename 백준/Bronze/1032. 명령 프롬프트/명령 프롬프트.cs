using System.Text;

namespace _1032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] arr = new string[N];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                arr[i] = Console.ReadLine();
            }

            for (int i = 0; i < arr[0].Length; i++)
            {
                char chr = ' ';

                for (int j = 0; j < N; j++)
                {
                    if (arr[0][i] != arr[j][i])
                    {
                        chr = '?';
                        sb.Append(chr);
                        break;
                    }
                }

                if (chr == ' ')
                {
                    chr = arr[0][i];
                    sb.Append(chr);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}