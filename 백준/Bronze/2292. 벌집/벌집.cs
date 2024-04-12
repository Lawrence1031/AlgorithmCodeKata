namespace _2292
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int curMax = 1;
            int layer = 1;

            while (curMax < N)
            {
                curMax += 6 * layer;
                layer++;
            }

            Console.WriteLine(layer);
        }
    }
}