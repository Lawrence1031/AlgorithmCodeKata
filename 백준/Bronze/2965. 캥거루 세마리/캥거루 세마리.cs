namespace _2965
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            int C = int.Parse(inputs[2]);

            int left = B - A;
            int right = C - B;

            int maxMoves = Math.Max(left, right) - 1;

            Console.WriteLine(maxMoves);
        }
    }
}