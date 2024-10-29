namespace _15340
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] prices = { { 30, 40 }, { 35, 30 }, { 40, 20 } };

            while (true)
            {
                int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int c = inputs[0];
                int d = inputs[1];
                
                if (c == 0 && d == 0)
                {
                    return;
                }

                int charge = Math.Min((c * prices[0, 0] + d * prices[0, 1]),
                             Math.Min((c * prices[1, 0] + d * prices[1, 1]),
                                      (c * prices[2, 0] + d * prices[2, 1])));
                Console.WriteLine(charge);
            }
        }
    }
}