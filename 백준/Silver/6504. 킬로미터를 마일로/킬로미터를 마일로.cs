using System.Text;

namespace _6504
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            List<int> kilometers = new List<int>();

            for (int i = 0; i < t; i++)
            {
                kilometers.Add(int.Parse(Console.ReadLine()));
            }

            List<int> fibonacci = GenerateFibonacci(25000);

            foreach (var km in kilometers)
            {
                int miles = ConvertMiles(km, fibonacci);
                sb.AppendLine(miles.ToString());
            }

            Console.WriteLine(sb.ToString());
        }

        static List<int> GenerateFibonacci(int max)
        {
            List<int> fibonacci = new List<int> { 1, 2 };
            while (true)
            {
                int nextFibo = fibonacci[fibonacci.Count - 1] + fibonacci[fibonacci.Count - 2];
                if (nextFibo > max) break;
                fibonacci.Add(nextFibo);
            }

            return fibonacci;
        }

        static int ConvertMiles(int km, List<int> fibonacci)
        {
            List<int> fibonacciRep = new List<int>();

            for (int i = fibonacci.Count - 1; i >= 0; i--)
            {
                if (fibonacci[i] <= km)
                {
                    km -= fibonacci[i];
                    fibonacciRep.Add(1);
                }
                else
                {
                    if (fibonacciRep.Count > 0)
                    {
                        fibonacciRep.Add(0);
                    }
                }
            }

            if (fibonacciRep.Count > 0)
            {
                fibonacciRep.RemoveAt(fibonacciRep.Count - 1);
            }

            int miles = 0;
            for (int i = 0; i < fibonacciRep.Count; i++)
            {
                if (fibonacciRep[i] == 1)
                {
                    miles += fibonacci[fibonacciRep.Count - 1 - i];
                }
            }

            return miles;
        }
    }
}