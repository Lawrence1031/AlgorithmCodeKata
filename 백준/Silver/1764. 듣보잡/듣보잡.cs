namespace _1764
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int N = int.Parse(input.Split(' ')[0]);
            int M = int.Parse(input.Split(' ')[1]);

            Dictionary<string, int> seeList = new Dictionary<string, int>();
            List<string> result = new List<string>();

            for (int i = 1; i <= N; i++)
            {
                input = Console.ReadLine();
                seeList.Add(input, 1);
            }

            for (int i = 1; i <= M; i++)
            {
                input = Console.ReadLine();
                if (seeList.ContainsKey(input))
                {
                    result.Add(input);
                }
            }

            result.Sort();

            Console.WriteLine(result.Count);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}