using System;

namespace _7572
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int convert = input + 56;
            int tens = convert % 10;
            int twes = convert % 12 + 65;
            char gan = Convert.ToChar(twes);
            Console.WriteLine($"{gan}{tens}");
        }
    }
}
