using System.Text;

namespace _25314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int result = N / 4;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < result; i++)
            {
                sb.Append("long ");
            }

            Console.WriteLine(sb.ToString() + "int");
        }
    }
}