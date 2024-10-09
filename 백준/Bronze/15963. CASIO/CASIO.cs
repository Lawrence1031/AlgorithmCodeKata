namespace _15963
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            long N = long.Parse(inputs[0]);
            long M = long.Parse(inputs[1]);

            Console.WriteLine(N == M ? "1" : "0");
        }
    }
}