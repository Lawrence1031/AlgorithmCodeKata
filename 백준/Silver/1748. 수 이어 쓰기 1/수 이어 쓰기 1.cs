using System.Text;

namespace _1748
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long digitCnt = 0;
            int length = 1;
            long powerOfTen = 10;

            while (N >= powerOfTen)
            {
                digitCnt += (powerOfTen - powerOfTen / 10) * length;
                length++;
                powerOfTen *= 10;
            }

            digitCnt += (N - powerOfTen / 10 + 1) * length;
            Console.WriteLine(digitCnt);
        }
    }
}