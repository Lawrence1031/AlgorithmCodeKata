using System.Linq;

namespace _1233
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int S1 = int.Parse(inputs[0]);
            int S2 = int.Parse(inputs[1]);
            int S3 = int.Parse(inputs[2]);

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 1; i <= S1; i++)
            {
                for (int j = 1; j <= S2; j++)
                {
                    for (int k = 1; k <= S3; k++)
                    {
                        int number = i + j + k;
                        if (!dict.ContainsKey(number))
                        {
                            dict.Add(number, 1);
                        }
                        else
                        {
                            dict[number]++;
                        }
                    }
                }
            }

            int maxCnt = dict.Values.Max();
            var LowestSum = dict.Where(x => x.Value == maxCnt).Min(x => x.Key);
            Console.WriteLine(LowestSum);
        }
    }
}