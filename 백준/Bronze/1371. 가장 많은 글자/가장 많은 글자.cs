namespace _1371
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            string input;

            while ((input = Console.ReadLine()) != null)
            {
                foreach (char c in input)
                {
                    if (char.IsLower(c))
                    {
                        if (dict.ContainsKey(c))
                        {
                            dict[c]++;
                        }
                        else
                        {
                            dict.Add(c, 1);
                        }
                    }
                }
            }

            int maxCnt = dict.Values.Max();
            var sortedDict = dict.Where(x => x.Value == maxCnt)
                                 .Select(x => x.Key)
                                 .OrderBy(x => x).ToList();
            
            foreach (var x in sortedDict)
            {
                Console.Write(x);
            }
        }
    }
}