namespace _23825
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            long N = long.Parse(inputs[0]);
            long M = long.Parse(inputs[1]);

            Console.WriteLine(Math.Min(N / 2, M / 2));
        }
    }
}