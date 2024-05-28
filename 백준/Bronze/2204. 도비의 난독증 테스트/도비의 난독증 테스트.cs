namespace _2204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == 0)
                {
                    return;
                }

                string[] words = new string[n];

                for (int i = 0; i < n; i++)
                {
                    words[i] = Console.ReadLine();
                }

                var wordsIdx = words.Select((value, index) => new { Value = value.ToLower(), Index = index })
                                       .OrderBy(x => x.Value)
                                       .ToList();

                Console.WriteLine(words[wordsIdx[0].Index]);
            }
        }
    }
}