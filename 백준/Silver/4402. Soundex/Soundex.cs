using System.Text;

namespace _4402
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while ((input = Console.ReadLine()) != null)
            {
                StringBuilder sb = new StringBuilder();
                char previousDigit = '\0';

                foreach (char c in input)
                {
                    char digit = GetSoundexDigit(c);

                    if (digit != '0' && digit != previousDigit)
                    {
                        sb.Append(digit);
                    }
                    previousDigit = digit;
                }

                Console.WriteLine(sb.ToString());
            }
        }

        private static char GetSoundexDigit(char c)
        {
            switch(c)
            {
                case 'B': case 'F': case 'P': case 'V':
                    return '1';
                case 'C': case 'G': case 'J': case 'K':
                case 'Q': case 'S': case 'X': case 'Z':
                    return '2';
                case 'D': case 'T':
                    return '3';
                case 'L':
                    return '4';
                case 'M': case 'N':
                    return '5';
                case 'R':
                    return '6';
                default:
                    return '0';
            }
        }
    }
}