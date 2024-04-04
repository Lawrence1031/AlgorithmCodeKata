using System.Text;

namespace _2438
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                sb.AppendLine(new string('*', i));
            }
            Console.WriteLine(sb.ToString());
        }
    }
}