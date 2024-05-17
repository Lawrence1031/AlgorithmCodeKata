using System.Text;

namespace _2154
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            int num = int.Parse(N);
            StringBuilder sb = new StringBuilder();
            int position = 0;
            int maxCheckLength = N.Length + 5;

            for (int i = 0; i <= num; i++)
            {
                sb.Append(i.ToString());

                if (sb.Length > maxCheckLength)
                {
                    sb = new StringBuilder(sb.ToString().Substring(sb.Length - maxCheckLength));
                }

                if (sb.ToString().Contains(N))
                {
                    position = i;
                    break;
                }
            }

            sb.Clear();
            for (int i = 1; i <= position; i++)
            {
                sb.Append(i.ToString());
            }

            int answer = sb.ToString().IndexOf(N) + 1;

            Console.WriteLine(answer);
        }
    }
}