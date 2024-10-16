namespace _23971
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int H = inputs[0];
            int W = inputs[1];
            int N = inputs[2];
            int M = inputs[3];

            int a = (H / (N + 1)) + (H % (N + 1) > 0 ? 1 : 0);
            int b = (W / (M + 1)) + (W % (M + 1) > 0 ? 1 : 0);

            Console.WriteLine(a * b);
        }
    }
}