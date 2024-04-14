namespace _9375
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            while (T > 0)
            {
                int N = int.Parse(Console.ReadLine());
                Dictionary<string, int> dict = new Dictionary<string, int>();
                for (int i = 0; i < N; i++)
                {
                    string[] inputs = Console.ReadLine().Split(' ');
                    if (dict.ContainsKey(inputs[1]))
                    {
                        dict[inputs[1]]++;
                    }
                    else
                    {
                        dict.Add(inputs[1], 1);
                    }
                }

                int combi = 1;
                foreach (var item in dict.Values)
                {
                    combi *= item + 1;
                }

                Console.WriteLine(combi - 1);
                T--;
            }
        }
    }
}