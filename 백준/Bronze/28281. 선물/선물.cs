namespace _28281
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int X = int.Parse(inputs[1]);
            int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int minPrice = int.MaxValue;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                int nowPrice = (prices[i] + prices[i + 1]) * X;
                if (nowPrice < minPrice)
                {
                    minPrice = nowPrice;
                }
            }

            Console.WriteLine(minPrice);
        }
    }
}