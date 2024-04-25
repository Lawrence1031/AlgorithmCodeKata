namespace _1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);

                List<int> pattern = new List<int>();
                HashSet<int> seen = new HashSet<int>();
                int cur = a % 10;

                while (!seen.Contains(cur))
                {
                    pattern.Add(cur);
                    seen.Add(cur);
                    cur = (cur * a) % 10;
                }

                int cycle = pattern.Count;
                int idx = (b - 1) % cycle;
                int result = pattern[idx];

                if (result == 0)
                    result = 10;
                Console.WriteLine(result);
            }
        }
    }
}