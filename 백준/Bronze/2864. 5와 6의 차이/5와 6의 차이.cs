using System.Text;

namespace _2864
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string A = inputs[0];
            string B = inputs[1];

            string minA = A.Replace('6', '5');
            string minB = B.Replace('6', '5');
            int min = int.Parse(minA) + int.Parse(minB);

            string maxA = A.Replace('5', '6');
            string maxB = B.Replace('5', '6');
            int max = int.Parse(maxA) + int.Parse(maxB);

            Console.WriteLine($"{min} {max}");
        }
    }
}