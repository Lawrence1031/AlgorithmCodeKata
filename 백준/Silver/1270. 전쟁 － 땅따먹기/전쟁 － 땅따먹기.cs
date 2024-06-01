namespace _1270
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().TrimEnd().Split(' ');
                Dictionary<long, int> condition = new Dictionary<long, int>();

                for (int j = 1; j < inputs.Length; j++)
                {
                    long army = long.Parse(inputs[j]);

                    if (condition.ContainsKey(army))
                    {
                        condition[army]++;
                    }
                    else
                    {
                        condition.Add(army, 1);
                    }
                }

                long conditionLen = condition.Select(x => x.Value).Sum();
                bool IsOccupy = false;
                long occupyArmy = 0;

                foreach (var item in condition)
                {
                    if (item.Value > conditionLen / 2)
                    {
                        IsOccupy = true;
                        occupyArmy = item.Key;
                        break;
                    }
                }

                Console.WriteLine(IsOccupy ? occupyArmy : "SYJKGW");
            }
        }
    }
}