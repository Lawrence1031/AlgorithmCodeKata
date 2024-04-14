namespace _17219
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            Dictionary<string, string> dict = new Dictionary<string, string>();

            for (int i = 0; i < N; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                dict.Add(inputs[0], inputs[1]);
            }

            for (int i = 0; i < M; i++)
            {
                string input = Console.ReadLine();
                if (dict.ContainsKey(input))
                {
                    Console.WriteLine(dict[input]);
                }
            }
        }
    }
}