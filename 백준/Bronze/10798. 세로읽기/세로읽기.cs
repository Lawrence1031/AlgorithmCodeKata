using System.Text;

namespace _10798
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 5; i++)
            {
                string input = Console.ReadLine();
                list.Add(input);
            }

            for (int j = 0; j < 15; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (j < list[i].Length)
                    {
                        sb.Append(list[i][j]);
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}