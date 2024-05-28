using System.Text;

namespace _5354
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                int len = int.Parse(Console.ReadLine());

                for (int j = 0; j < len; j++)
                {
                    for (int k = 0; k < len; k++)
                    {
                        if (j > 0 && j < len - 1 && k > 0 && k < len - 1)
                        {
                            sb.Append("J");
                        }
                        else
                        {
                            sb.Append("#");
                        }
                    }
                    sb.AppendLine();
                }

                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}