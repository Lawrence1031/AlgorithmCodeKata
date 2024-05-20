using System.Text;

namespace _1373
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();

            while (binary.Length % 3 != 0)
            {
                binary = "0" + binary;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < binary.Length; i += 3)
            {
                string segment = binary.Substring(i, 3);
                int octDigit = Convert.ToInt32(segment, 2);
                sb.Append(octDigit);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}