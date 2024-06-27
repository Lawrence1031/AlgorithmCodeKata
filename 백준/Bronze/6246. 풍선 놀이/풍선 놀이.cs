namespace _6246
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int Q = int.Parse(inputs[1]);
            HashSet<int> slots = new HashSet<int>();

            for (int i = 0; i < Q; i++)
            {
                string[] commands = Console.ReadLine().Split(' ');
                int L = int.Parse(commands[0]);
                int I = int.Parse(commands[1]);

                while (L <= N)
                {
                    slots.Add(L);
                    L += I;
                }
            }

            Console.WriteLine(N - slots.Count);
        }
    }
}