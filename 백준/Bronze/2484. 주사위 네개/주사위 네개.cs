namespace _2484
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxPrice = 0;

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                Dictionary<int, int> dices = new Dictionary<int, int>();
                
                for (int j = 0; j < 4; j++)
                {
                    int diceNumber = int.Parse(inputs[j]);
                    if (dices.ContainsKey(diceNumber))
                    {
                        dices[diceNumber]++;
                    }
                    else
                    {
                        dices[diceNumber] = 1;
                    }
                }

                int price = ReturnPrice(dices);

                if (price > maxPrice) maxPrice = price;
            }

            Console.WriteLine(maxPrice);
        }

        static int ReturnPrice(Dictionary<int, int> dices)
        {
            int price = 0;

            if (dices.ContainsValue(4))
            {
                int value = dices.First(x => x.Value == 4).Key;
                price = 50000 + value * 5000;
            }
            else if (dices.ContainsValue(3))
            {
                int value = dices.First(x => x.Value == 3).Key;
                price = 10000 + value * 1000;
            }
            else if (dices.ContainsValue(2) && dices.Count == 2)
            {
                int[] values = dices.Keys.ToArray();
                price = 2000 + values[0] * 500 + values[1] * 500;
            }
            else if (dices.ContainsValue(2))
            {
                int value = dices.First(x => x.Value == 2).Key;
                price = 1000 + value * 100;
            }
            else
            {
                int value = dices.Max(x => x.Key);
                price = value * 100;
            }

            return price;
        }
    }
}