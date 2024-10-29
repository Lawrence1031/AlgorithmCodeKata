namespace _1864
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "#")
                {
                    return;
                }

                Console.WriteLine(SymbolToOctal(input));
            }
        }

        static double SymbolToOctal(string input)
        {
            double number = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '/')
                {
                    number += -SymbolToNum(input[i]) * Math.Pow(8, input.Length - 1 - i);
                }
                else
                {
                    number += SymbolToNum(input[i]) * Math.Pow(8, input.Length - 1 - i);
                }
            }

            return number;
        }

        static int SymbolToNum(char c)
        {
            switch (c)
            {
                case '-': return 0;
                case '\\': return 1;
                case '(': return 2;
                case '@': return 3;
                case '?': return 4;
                case '>': return 5;
                case '&': return 6;
                case '%': return 7;
                default: return 1;
            }
        }
    }
}