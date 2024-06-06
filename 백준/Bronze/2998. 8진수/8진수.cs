using System.Text;

namespace _2998
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input.Length % 3 != 0)
            {
                input = input.PadLeft(input.Length + 1, '0');
            }

            string oct = MakeOct(input);
            Console.WriteLine(oct);
        }

        static string MakeOct(string input)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i += 3)
            {
                int now = int.Parse(input.Substring(i, 3));
                int result = now / 100 * 4 + ((now % 100) / 10 * 2) + now % 10;
                sb.Append(result.ToString());
            }

            return sb.ToString();
        }
    }
}