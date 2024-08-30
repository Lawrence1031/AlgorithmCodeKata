namespace _24724
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int test = 1; test <= T; test++)
            {
                int N = int.Parse(Console.ReadLine());
                string[] inputs = Console.ReadLine().Split(' ');
                int A = int.Parse(inputs[0]);
                int B = int.Parse(inputs[1]);

                for (int i = 0; i < N; i++)
                {
                    string[] parts = Console.ReadLine().Split(' ');
                    int u = int.Parse(parts[0]);
                    int v = int.Parse(parts[1]);
                }

                Console.WriteLine($"Material Management {test}");
                Console.WriteLine("Classification ---- End!");
            }
        }
    }
}