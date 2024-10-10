namespace _12034
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int test = 0; test < T; test++)
            {
                int N = int.Parse(Console.ReadLine());
                List<long> prices = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
                List<long> newPrices = new List<long>();
                Dictionary<long, int> priceCount = new Dictionary<long, int>();

                foreach (long price in prices)
                {
                    if (!priceCount.ContainsKey(price))
                    {
                        priceCount[price] = 0;
                    }
                    priceCount[price]++;
                }

                foreach (long price in prices)
                {
                    if (priceCount[price] == 0)
                    {
                        continue;
                    }

                    newPrices.Add(price);

                    long originalPrice = price * 4 / 3;
                    priceCount[price]--;
                    priceCount[originalPrice]--;

                    if (newPrices.Count == N)
                    {
                        break;
                    }
                }

                Console.WriteLine($"Case #{test + 1}: {string.Join(" ", newPrices)}");
            }
        }
    }
}