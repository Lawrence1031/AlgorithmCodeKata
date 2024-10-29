namespace _15751
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int a = inputs[0];
            int b = inputs[1];
            int x = inputs[2];
            int y = inputs[3];

            int distance = Math.Abs(a - b);
            int telpoEnter = Math.Abs(Math.Min(a, b) - Math.Min(x, y));
            int telpoExit = Math.Abs(Math.Max(a, b) - Math.Max(x, y));
            int telpoDistance = telpoExit + telpoEnter;

            Console.WriteLine(Math.Min(distance, telpoDistance));
        }
    }
}