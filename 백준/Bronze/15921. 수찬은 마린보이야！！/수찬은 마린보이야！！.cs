namespace _15921
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if (N == 0)
            {
                Console.WriteLine("divide by zero");
                return;
            }

            int[] data = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            double rev = data.Average();

            if (rev == 0)
            {
                Console.WriteLine("divide by zero");
                return;
            }

            double expected = data.Sum() / (double)data.Length;

            Console.WriteLine((rev / expected).ToString("F2"));
        }
    }
}