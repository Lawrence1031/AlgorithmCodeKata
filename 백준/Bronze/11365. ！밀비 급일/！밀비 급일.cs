using System.Text;

namespace _11365
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                for (int i = 0; i < input.Length; i++)
                {
                    sb.Insert(0, input[i]);
                }
                Console.WriteLine(sb.ToString());
                sb.Clear();
            }
        }
    }
}