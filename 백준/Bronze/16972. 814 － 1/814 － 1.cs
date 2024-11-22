using System.Text;

namespace _16972
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 814; i++)
            {
                int x = random.Next(-8140, 8140);
                int y = random.Next(-8140, 8140);

                sb.AppendLine($"{x} {y}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}