using System.Text;

namespace _32288
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                if (input[i] == 'I')
                {
                    sb.Append('i');
                }
                else
                {
                    sb.Append('L');
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}