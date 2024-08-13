namespace _9070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int test = 0; test < T; test++)
            {
                int N = int.Parse(Console.ReadLine());
                Dictionary<int, int> dict = new Dictionary<int, int>();
                for (int i = 0; i < N; i++)
                {
                    string[] inputs = Console.ReadLine().Split(' ');
                    int weight = int.Parse(inputs[0]);
                    int price = int.Parse(inputs[1]);

                    if (dict.ContainsKey(weight))
                    {
                        if (price < dict[weight])
                        {
                            dict[weight] = price;
                        }
                    }
                    else
                    {
                        dict.Add(weight, price);
                    }
                }

                var lowestPrice = dict
                    .OrderBy(x => (double)x.Value / x.Key)
                    .ThenBy(x => x.Value)
                    .First();

                Console.WriteLine(lowestPrice.Value);
            }
        }
    }
}