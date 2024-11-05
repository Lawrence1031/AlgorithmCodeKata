using System.Text;

namespace _5300
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= N; i++)
            {
                sb.Append(i + " ");

                if (i % 6 == 0)
                {
                    sb.Append("Go! ");
                }
            }

            if (N % 6 != 0)
            {
                sb.Append("Go!");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}