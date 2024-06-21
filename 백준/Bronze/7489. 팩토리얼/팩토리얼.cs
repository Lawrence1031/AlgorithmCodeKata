using System.Text;

namespace _7489
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int answer = (int)FindFactorial(n);
                sb.AppendLine(answer.ToString());
            }

            Console.WriteLine(sb.ToString());
        }

        static double FindFactorial(int n)
        {
            long number = 1;
            for (int i = 1; i <= n; i++)
            {
                number *= i;

                while (number % 10 == 0)
                {
                    number /= 10;
                }

                number %= 10000;
            }

            return number % 10;
        }
    }
}