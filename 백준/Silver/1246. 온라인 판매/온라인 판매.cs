namespace _1246
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int[] prices = new int[M];

            for (int i = 0; i < M; i++)
            {
                prices[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(prices);

            int HighestSum = 0;
            int nowSum = 0;
            int price = 0;

            for (int i = 0; i < M; i++)
            {
                int egg = N > (M - i) ? M - i : N;
                nowSum = prices[i] * egg;

                if (nowSum > HighestSum)
                {
                    price = prices[i];
                    HighestSum = nowSum;
                }
            }
            
            Console.WriteLine($"{price} {HighestSum}");
        }
    }
}