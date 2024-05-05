using System.Text;

namespace _1212
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "0")
            {
                Console.WriteLine("0");
                return;
            }

            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                int octDigit = c - '0';
                string binaryStr = Convert.ToString(octDigit, 2);

                if (sb.Length > 0)
                {
                    binaryStr = binaryStr.PadLeft(3, '0');
                }

                sb.Append(binaryStr);
            }
            Console.WriteLine(sb.ToString());            
        }
    }
}