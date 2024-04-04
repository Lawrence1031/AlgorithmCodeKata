using System.Text;

namespace _2675
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < a; i++)
            {
                string s1 = Console.ReadLine();
                string[] ss = s1.Split(' ');

                for (int j = 0; j < ss[1].Length; j++)
                {
                    char c = Convert.ToChar(ss[1][j]);
                    sb.Append(new string(c, Convert.ToInt32(ss[0])));
                }
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}