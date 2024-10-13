using System.Numerics;

namespace _32278
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int n;

            if (int.TryParse(input, out n))
            {
                if (n >= -32768 && n <= 32767)
                {
                    Console.WriteLine("short");
                }
                else if (n >= -2147483648 && n <= 2147483647)
                {
                    Console.WriteLine("int");
                }
            }
            else
            {
                Console.WriteLine("long long");
            }
        }
    }
}