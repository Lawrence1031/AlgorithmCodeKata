namespace _25628
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int A = inputs[0];
            int B = inputs[1];

            Console.WriteLine(Math.Min(A / 2, B));
        }
    }
}