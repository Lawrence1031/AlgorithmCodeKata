using System.Numerics;

namespace _1247
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                int n = int.Parse(Console.ReadLine());
                BigInteger sum = 0;

                for (int j = 0; j < n; j++)
                {
                    sum += long.Parse(Console.ReadLine());
                }

                if (sum > 0)
                {
                    Console.WriteLine("+");
                }
                else if (sum == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
        }
    }
}