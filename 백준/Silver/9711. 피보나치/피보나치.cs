using System.Numerics;
using System.Text;

namespace _9711
{
    internal class Program
    {
        static List<BigInteger> Fibo = new List<BigInteger>();
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            Fibonacci();

            for (int i = 0; i < T; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int P = int.Parse(inputs[0]) - 1;
                long Q = long.Parse(inputs[1]);
                BigInteger answer = Fibo[P] % Q;

                sb.AppendLine($"Case #{i + 1}: {answer}");
            }

            Console.WriteLine(sb.ToString());
        }

        static void Fibonacci()
        {
            Fibo.Add(1);
            Fibo.Add(1);

            for (int i = 2; i < 10000; i++)
            {
                Fibo.Add(Fibo[i - 1] + Fibo[i - 2]);
            }
        }
    }
}