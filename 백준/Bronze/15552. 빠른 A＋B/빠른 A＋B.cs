using System.Text;

namespace _15552
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string s = Console.ReadLine();
            int t = Convert.ToInt32(s);

            string[] ss = new string[t];

            for (int i = 0; i < ss.Length; i++)
            {
                ss[i] = Console.ReadLine();
            }

            for (int i = 0; i < ss.Length; i++)
            {
                string[] ss2 = ss[i].Split(' ');
                int a = Convert.ToInt32(ss2[0]);
                int b = Convert.ToInt32(ss2[1]);
                sb.AppendLine((a + b).ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}