namespace _26082
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int A = inputs[0];
            int B = inputs[1];
            int C = inputs[2];

            Console.WriteLine(3 * C * B / A);
        }
    }
}