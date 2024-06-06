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
                string now = input.Substring(i, 3);
                switch (now)
                {
                    case "000": sb.Append('0'); break;
                    case "001": sb.Append('1'); break;
                    case "010": sb.Append('2'); break;
                    case "011": sb.Append('3'); break;
                    case "100": sb.Append('4'); break;
                    case "101": sb.Append('5'); break;
                    case "110": sb.Append('6'); break;
                    case "111": sb.Append('7'); break;
                }
            }

            return sb.ToString();
        }
    }
}