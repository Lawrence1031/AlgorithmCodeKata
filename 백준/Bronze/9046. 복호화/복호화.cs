namespace _9046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int test = 0; test < T; test++)
            {
                string input = Console.ReadLine();
                Dictionary<char, int> dict = new Dictionary<char, int>();
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != ' ')
                    {
                        if (!dict.ContainsKey(input[i]))
                        {
                            dict.Add(input[i], 1);
                        }
                        else
                        {
                            dict[input[i]]++;
                        }
                    }
                }

                var maxCnt = dict.Values.Max();
                var maxKeys = dict.Where(x => x.Value == maxCnt).Select(x => x.Key).ToList();

                if (maxKeys.Count == 1)
                {
                    Console.WriteLine(maxKeys[0]);
                }
                else
                {
                    Console.WriteLine("?");
                }

            }

        }
    }
}