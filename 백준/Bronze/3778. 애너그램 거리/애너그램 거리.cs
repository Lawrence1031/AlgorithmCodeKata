namespace _3778
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string word1 = Console.ReadLine();
                string word2 = Console.ReadLine();
                Dictionary<char, int> dict1 = new Dictionary<char, int>();
                Dictionary<char, int> dict2 = new Dictionary<char, int>();

                for (int j = 0; j < word1.Length; j++)
                {
                    if (dict1.ContainsKey(word1[j]))
                    {
                        dict1[word1[j]]++;
                    }
                    else
                    {
                        dict1.Add(word1[j], 1);
                    }
                }

                for (int j = 0; j < word2.Length; j++)
                {
                    if (dict2.ContainsKey(word2[j]))
                    {
                        dict2[word2[j]]++;
                    }
                    else
                    {
                        dict2.Add(word2[j], 1);
                    }
                }

                int cnt = 0;

                foreach (var item in dict1.Keys)
                {
                    if (dict2.ContainsKey(item))
                    {
                        cnt += Math.Abs(dict1[item] - dict2[item]);
                    }
                    else
                    {
                        cnt += Math.Abs(dict1[item]);
                    }
                }

                foreach (var item in dict2.Keys)
                {
                    if (!dict1.ContainsKey(item))
                    {
                        cnt += Math.Abs(dict2[item]);
                    }
                }

                Console.WriteLine($"Case #{i + 1}: {cnt}");
            }
        }
    }
}