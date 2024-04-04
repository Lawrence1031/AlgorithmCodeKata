using System.Text;

namespace _2741
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = Convert.ToInt32(s);
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= a; i++)
            {
                sb.AppendLine(i.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}